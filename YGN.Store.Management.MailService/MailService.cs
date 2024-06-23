using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using YGN.Store.Management.DataAccess.Context;
using System.Timers;
using System.Net.Mail;
using System.Net;
using YGN.Store.Management.Common.ConfigHelpers;
using YGN.Store.Management.Entities.Concrete;
using YGN.Store.Management.Business.Concrete;
using YGN.Store.Management.DataAccess.Concrete.EntityFramework;
using System.IO;
using System.Xml.Linq;
using YGN.Store.Management.Entities.Views;
using iTextSharp.text.pdf;
using iTextSharp.text;
using static Org.BouncyCastle.Math.EC.ECCurve;

namespace YGN.Store.Management.MailService
{
    public partial class MailService : ServiceBase
    {
        #region members
        ReportManager reportManager = new ReportManager(new EfReportDal());
        private Timer timer = new Timer();
        private YGNContext dbContext;
        #endregion

        #region constructor
        public MailService()
        {
            this.ServiceName = "YGN-Mail-Service";
            InitializeComponent();
            dbContext = new YGNContext();
            writelog("YGN Service Kuruldu");
        }
        #endregion

        #region events
        protected override void OnStart(string[] args)
        {
            timer.Start();
            timer.Interval = 60000;
            timer.Elapsed += new ElapsedEventHandler(OnElapsedTime);
            timer.Enabled = true;
            writelog("YGN Service Başladı");
        }
        protected override void OnStop()
        {
            timer.Stop();
            dbContext.Dispose();
            writelog("YGN Service Durdu");
        }
        private void OnElapsedTime(object source, ElapsedEventArgs e)
        {
            SendEmails();
        }
        #endregion

        #region private methods
        private MailConfig GetMailInformation()
        {
            try
            {
                MailConfig config = new MailConfig();
                var mailKeys = new List<string> { "SmtpServer", "MailAddress", "Password", "MailPort", "Ssl" };

                foreach (var key in mailKeys)
                {
                    var info = ConfigManager.GetMailInformation(key);
                    EventLog.WriteEntry($"Config Bilgileri: {info}", EventLogEntryType.Information); 

                    if (!string.IsNullOrEmpty(info))
                    {
                        switch (key)
                        {
                            case "SmtpServer":
                                config.SmtpServer = info;
                                break;
                            case "MailAddress":
                                config.FromMailAddress = info;
                                break;
                            case "Password":
                                config.Password = info;
                                break;
                            case "MailPort":
                                config.MailPort = info;
                                break;
                            case "Ssl":
                                config.Ssl = Convert.ToBoolean(info);
                                break;
                        }
                    }
                    else
                    {
                        EventLog.WriteEntry($"Missing or incomplete configuration key: {key}", EventLogEntryType.Error);
                    }
                }

                if (string.IsNullOrEmpty(config.SmtpServer) || string.IsNullOrEmpty(config.FromMailAddress) || string.IsNullOrEmpty(config.Password))
                {
                    EventLog.WriteEntry("Incomplete mail configuration detected.", EventLogEntryType.Error);
                    return null; 
                }

                return config;
            }
            catch (Exception ex)
            {
                EventLog.WriteEntry($"Error in GetMailInformation: {ex.Message}", EventLogEntryType.Error);
                return null; 
            }
        }
        private byte[] GeneratePdf(string title, List<StockAmountView> data)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                Document doc = new Document(PageSize.A4);
                PdfWriter writer = PdfWriter.GetInstance(doc, ms);
                doc.Open();

                Paragraph heading = new Paragraph(title, new Font(Font.FontFamily.HELVETICA, 18, Font.BOLD));
                heading.Alignment = Element.ALIGN_CENTER;
                doc.Add(heading);

                doc.Add(new Paragraph(" ", new Font(Font.FontFamily.HELVETICA, 10)));

                PdfPTable table = new PdfPTable(3);

                Font boldFont = new Font(Font.FontFamily.HELVETICA, 11, Font.BOLD);
                table.AddCell(new PdfPCell(new Phrase("Malzeme Kodu", boldFont)));
                table.AddCell(new PdfPCell(new Phrase("Malzeme Adı", boldFont)));
                table.AddCell(new PdfPCell(new Phrase("Stok Miktarı", boldFont)));

                foreach (var item in data)
                {
                    table.AddCell(new Phrase(item.ItemCode.ToString()));
                    table.AddCell(new Phrase(item.ItemName.ToString()));
                    table.AddCell(new Phrase(item.StockAmount.ToString()));
                }
                writelog(data.Count().ToString(),EventLogEntryType.Error);
                doc.Add(table);

                doc.Close();
                return ms.ToArray();
            }
        }
        private void SendEmailWithAttachment(string recipient, string subject, string body, byte[] pdfAttachment)
        {
            try
            {
                var mailInfo = GetMailInformation();

                if (mailInfo == null)
                {
                    writelog("Mail information is null", EventLogEntryType.Error);
                    return;
                }

                if (string.IsNullOrEmpty(mailInfo.FromMailAddress) || string.IsNullOrEmpty(mailInfo.SmtpServer) || string.IsNullOrEmpty(mailInfo.Password))
                {
                    writelog("Mail information properties are null or empty", EventLogEntryType.Error);
                    return;
                }

                if (pdfAttachment == null)
                {
                    writelog("PDF attachment is null", EventLogEntryType.Error);
                    return;
                }


                MailMessage mail = new MailMessage(mailInfo.FromMailAddress, recipient, subject, body);
                mail.Attachments.Add(new Attachment(new MemoryStream(pdfAttachment), "Report.pdf", "application/pdf"));

                using (SmtpClient client = new SmtpClient(mailInfo.SmtpServer))
                {
                    client.Port = Convert.ToInt32(mailInfo.MailPort);
                    client.Credentials = new NetworkCredential(mailInfo.FromMailAddress, mailInfo.Password);
                    client.EnableSsl = mailInfo.Ssl;
                    client.Send(mail);
                }
            }
            catch (Exception ex)
            {
                writelog($"Exception: {ex.Message}", EventLogEntryType.Error);
                if (ex.InnerException != null)
                {
                    writelog($"Inner Exception: {ex.InnerException.Message}", EventLogEntryType.Error);
                }
            }
        }
        private void SendEmails()
        {
            var emailsToSend = dbContext.SendMails.ToList();

            foreach (var email in emailsToSend)
            {
                if ((DateTime.Now - email.LastSent).TotalMinutes >= email.Frequency)
                {
                    var data = reportManager.GetStockAmountEachItem();
                    if (data == null)
                    {
                        writelog(string.Format("Sorgu içeriği boş geldi."),EventLogEntryType.Warning);
                        return;
                    }

                    var pdfAttachment = GeneratePdf(email.Subject, data);

                    SendEmailWithAttachment(email.Recipient, email.Subject, email.Body, pdfAttachment);
                    email.LastSent = DateTime.Now;
                }
            }

            dbContext.SaveChanges();
        }
        private void writelog(string message)
        {
            writelog(message, EventLogEntryType.Information);
        }
        private void writelog(string message, EventLogEntryType eventLogEntryType)
        {
            this.EventLog.WriteEntry(string.Format("{0}", message), eventLogEntryType);
        }
        #endregion

    }
    public class MailConfig
    {
        public string FromMailAddress { get; set; }
        public string SmtpServer { get; set; }
        public string Password { get; set; }
        public string MailPort { get; set; }
        public bool Ssl { get; set; }
    }
}
