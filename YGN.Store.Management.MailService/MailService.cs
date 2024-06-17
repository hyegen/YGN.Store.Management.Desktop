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
using YGN.Store.Management.Business.Concrete;
using YGN.Store.Management.DataAccess.Concrete.EntityFramework;
using System.Runtime.InteropServices;

namespace YGN.Store.Management.MailService
{
    public partial class MailService : ServiceBase
    {
        private Timer timer = new Timer();
        private YGNContext dbContext;
        public MailService()
        {
            this.ServiceName = "Service1";
            InitializeComponent();
            dbContext = new YGNContext();
            timer.Interval = 60000;
            timer.Elapsed += new ElapsedEventHandler(OnElapsedTime);
            timer.Enabled = true;
        }
        protected override void OnStart(string[] args)
        {
            timer.Start();
        }
        protected override void OnStop()
        {
            timer.Stop();
            dbContext.Dispose();
        }
        private void OnElapsedTime(object source, ElapsedEventArgs e)
        {
            SendEmails();
        }
        private void SendEmails()
        {
            var emailsToSend = dbContext.SendMails.ToList();

            EventLog.WriteEntry(string.Format("E-mail Sayısı: {0}", emailsToSend.Count().ToString()), EventLogEntryType.Information);

            foreach (var email in emailsToSend)
            {
                //if ((DateTime.Now - email.LastSent).TotalMinutes >= email.Frequency)
                // {
                EventLog.WriteEntry(string.Format("Frequency: {0}", email.Frequency));
                SendEmail(email.Recipient, email.Subject, email.Body);
                email.LastSent = DateTime.Now;
                // }
            }

            dbContext.SaveChanges();
        }
        private void SendEmail(string recipient, string subject, string body)
        {
            try
            {
                MailMessage mail = new MailMessage("yegensmtp@gmail.com", recipient, subject, body);
                SmtpClient client = new SmtpClient("smtp.gmail.com");
                client.Port = 587;
                client.Credentials = new NetworkCredential("yegensmtp@gmail.com", "klykhjqdiwuchzip");
                client.EnableSsl = true;
                client.Send(mail);
                EventLog.WriteEntry(string.Format("Gönderilen Mail YGN-S-Management: {0}", mail.Subject.ToString()));
            }
            catch (Exception ex)
            {
                EventLog.WriteEntry("Mail gönderme hatası: {0}" ,ex.Message);
            }
        }
    }
}
