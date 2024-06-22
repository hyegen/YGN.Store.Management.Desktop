using System;
using System.Configuration;
using System.Configuration.Install;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.ServiceProcess;
using System.Windows.Forms;
using YGN.Store.Management.Common.ConfigHelpers;
using YGN.Store.Management.Common.FormHelpers;
using YGN.Store.Management.Sys.Managers;

namespace YGN.Store.Management.Sys.MailSetting
{
    public partial class MailSettingsForm : Form
    {
        #region members
        private ServiceController serviceController;
        #endregion

        #region properties
        public string SmtpServer
        {
            get { return txtSmtpServer.Text; }
            set
            {
                txtSmtpServer.Text = value;
            }
        }
        public string MailAddress_
        {
            get { return txtMailAddress.Text; }
            set
            {
                txtMailAddress.Text = value;
            }
        }
        public string Password
        {
            get { return txtMailPassword.Text; }
            set
            {
                txtMailPassword.Text = value;
            }
        }
        public string MailPort
        {
            get { return txtPort.Text; }
            set
            {
                txtPort.Text = value;
            }
        }
        public bool Ssl
        {
            get { return sslCheckBox.Checked; }
            set
            {
                sslCheckBox.Checked = value;
            }
        }
        #endregion

        #region constructor
        public MailSettingsForm()
        {
            InitializeComponent();
            LoadMailInformations();
            serviceController = new ServiceController("YGN-Mail-Service");
        }
        #endregion

        #region events
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                ConfigManager.SaveMailInformations("SmtpServer", SmtpServer);
                ConfigManager.SaveMailInformations("MailAddress", MailAddress_);
                ConfigManager.SaveMailInformations("Password", Password);
                ConfigManager.SaveMailInformations("MailPort", MailPort);
                ConfigManager.SaveMailInformations("Ssl", Ssl.ToString());

                MessageBox.Show("Değerler başarıyla kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnInstallMailService_Click(object sender, EventArgs e)
        {
            InstallService();
        }
        private void btnUninstallMailService_Click(object sender, EventArgs e)
        {
            UninstallService();
        }
        private void MailSettingsForm_Load(object sender, EventArgs e)
        {
            GetServerInformations();
            lblServiceStatusDescription.Text = GetMailServiceStatus();
        }
        private void btnSendMailReports_Click(object sender, EventArgs e)
        {
            FormHelper.ShowForm<ReportsForm>();
        }

        #endregion

        #region private methods
        private void LoadMailInformations()
        {
            txtMailAddress.Text = ConfigurationManager.AppSettings["MailAddres"] ?? "Mail Adresi Bulunamadı";
            txtMailPassword.Text = ConfigurationManager.AppSettings["Password"] ?? "Şifre Bulunamadı";
            txtPort.Text = ConfigurationManager.AppSettings["MailPort"] ?? "Mail Portu Bulunamadı";
        }
        private void InstallService()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Executable Files (*.exe)|*.exe";
                openFileDialog.Title = "MailService.exe dosyasını seçin";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string mailServicePath = openFileDialog.FileName;
                    string installUtilPath = @"C:\Windows\Microsoft.NET\Framework\v4.0.30319\InstallUtil.exe";

                    if (File.Exists(mailServicePath) && File.Exists(installUtilPath))
                    {
                        try
                        {
                            Process process = new Process();
                            process.StartInfo.FileName = installUtilPath;
                            process.StartInfo.Arguments = "\"" + mailServicePath + "\"";
                            process.StartInfo.RedirectStandardOutput = true;
                            process.StartInfo.RedirectStandardError = true;
                            process.StartInfo.UseShellExecute = false;
                            process.StartInfo.CreateNoWindow = true;
                            process.Start();

                            string output = process.StandardOutput.ReadToEnd();
                            string error = process.StandardError.ReadToEnd();
                            process.WaitForExit();

                            if (process.ExitCode == 0)
                            {
                                MessageBox.Show("Servis başarıyla kuruldu.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Servis kurulurken bir hata oluştu. Hata kodu: " + process.ExitCode + "\n" + error);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Kurulum sırasında hata oluştu: " + ex.Message);
                        }
                    }
                    else
                    {
                        MessageBox.Show("InstallUtil.exe veya seçilen dosya bulunamadı.");
                    }
                }
            }
        }
        private void UninstallService()
        {
            ServiceManager serviceManager = new ServiceManager("YGN-Mail-Service");
            serviceManager.UninstallService();
        }
        private void GetServerInformations()
        {
            try
            {
                SmtpServer = ConfigManager.GetMailInformation("SmtpServer") ?? "Smtp Sunucusu Giriniz.";
                MailAddress_ = ConfigManager.GetMailInformation("MailAddress") ?? "Mail Adresi Giriniz.";
                Password = ConfigManager.GetMailInformation("Password") ?? "Şifre Giriniz.";
                MailPort = ConfigManager.GetMailInformation("MailPort") ?? "Port Numarası Giriniz.";
                bool.TryParse(ConfigManager.GetMailInformation("Ssl"), out bool ssl);
                Ssl = ssl;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private string GetMailServiceStatus()
        {
            ServiceController sc = new ServiceController("YGN-Mail-Service");

            if (sc != null)
            {
<<<<<<< HEAD
                switch (sc.Status)
                {
                    case ServiceControllerStatus.Running:
                        return "Çalışıyor";
                    case ServiceControllerStatus.Stopped:
                        return "Durdu";
                    case ServiceControllerStatus.Paused:
                        return "Duraklatıldı";
                    case ServiceControllerStatus.StopPending:
                        return "Beklemeyi Durduruyor";
                    case ServiceControllerStatus.StartPending:
                        return "Bekleme Başlatılıyor";             //bekleme başlatılıyor :D Tureng yalancısıyım.
                    default:
                        return "Varsayılan";
                }
=======
                case ServiceControllerStatus.Running:
                    return "Çalışıyor";
                case ServiceControllerStatus.Stopped:
                    return "Durdu";
                case ServiceControllerStatus.Paused:
                    return "Duraklatıldı";
                case ServiceControllerStatus.StopPending:       
                    return "Beklemeyi Durduruyor";
                case ServiceControllerStatus.StartPending:
                    return "Bekleme Başlatılıyor";             //bekleme başlatılıyor :D Tureng yalancısıyım.
                default:
                    return "Varsayılan";
>>>>>>> 16e1c3854e8d92385ce87626604ba28a0281f5d3
            }

            return "";
        }
        #endregion

        private void btnStartMailService_Click(object sender, EventArgs e)
        {
            try
            {
                if (serviceController.Status == ServiceControllerStatus.Stopped)
                {
                    serviceController.Start();
                    serviceController.WaitForStatus(ServiceControllerStatus.Running);
                    MessageBox.Show("Servis Başlatıldı.");
                    GetMailServiceStatus();
                }
                else
                {
                    MessageBox.Show("Servis zaten çalışıyor.");
                }
              
            }
            catch (Exception ex)
            {
                MessageBox.Show("Başlatma sırasında hata: " + ex.Message);
            }
           
        }

        private void btnStopMailService_Click(object sender, EventArgs e)
        {
            try
            {
                if (serviceController.Status == ServiceControllerStatus.Running)
                {
                    serviceController.Stop();
                    serviceController.WaitForStatus(ServiceControllerStatus.Stopped);
                    MessageBox.Show("Servis Durduruldu.");
                    GetMailServiceStatus();
                }
                else
                {
                    MessageBox.Show("Servis zaten durdurulmuş.");
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Durdurma sırasında hata: " + ex.Message);
            }
            
        }
    }
}
