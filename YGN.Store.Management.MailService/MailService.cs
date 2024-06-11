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

namespace YGN.Store.Management.MailService
{
    public partial class MailService : ServiceBase
    {
        private Timer timer;
        private YGNContext dbContext;

        public MailService()
        {
            InitializeComponent();
            dbContext = new YGNContext();
        }

        protected override void OnStart(string[] args)
        {
            timer = new Timer();
            timer.Interval = 60000; // Her dakika kontrol et
            timer.Elapsed += new ElapsedEventHandler(OnElapsedTime);
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

            foreach (var email in emailsToSend)
            {
                if ((DateTime.Now - email.LastSent).TotalMinutes >= email.Frequency)
                {
                    SendEmail(email.Recipient, email.Subject, email.Body);
                    email.LastSent = DateTime.Now; 
                }
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
                EventLog.WriteEntry("Gönderilen Mail YGN: " + mail.Body.ToString());
            }
            catch (Exception ex)
            {
                // Hata yönetimi
                EventLog.WriteEntry("Mail gönderme hatası: " + ex.Message);
            }
        }
    }
}
