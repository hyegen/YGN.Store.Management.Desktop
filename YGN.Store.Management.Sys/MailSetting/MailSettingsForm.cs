using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Configuration.Install;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace YGN.Store.Management.Sys.MailSetting
{
    public partial class MailSettingsForm : Form
    {
        public MailSettingsForm()
        {
            InitializeComponent();
            LoadMailInformations();
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                MailManager.SaveMailInformations("MailAddress", MailAddress_);
                MailManager.SaveMailInformations("Password", Password);
                MailManager.SaveMailInformations("MailPort", MailPort);
                MailManager.SaveMailInformations("Ssl", Ssl.ToString());

                MessageBox.Show("Değerler başarıyla kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadMailInformations()
        {
            txtMailAddress.Text = ConfigurationManager.AppSettings["MailAddres"] ?? "Mail Adresi Bulunamadı";
            txtMailPassword.Text = ConfigurationManager.AppSettings["Password"] ?? "Şifre Bulunamadı";
            txtPort.Text = ConfigurationManager.AppSettings["MailPort"] ?? "Mail Portu Bulunamadı";
        }

        private void btnInstallMailService_Click(object sender, EventArgs e)
        {
            InstallService();
        }
        //private void InstallService()
        //{
        //    try
        //    {
        //        ManagedInstallerClass.InstallHelper(new string[] { Assembly.GetExecutingAssembly().Location });
        //        MessageBox.Show("Servis başarıyla kuruldu.");
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Kurulum sırasında hata oluştu: " + ex.Message);
        //    }
        //}
        //private void InstallService()
        //{
        //    using (OpenFileDialog openFileDialog = new OpenFileDialog())
        //    {
        //        openFileDialog.Filter = "Executable Files (*.exe)|*.exe";
        //        openFileDialog.Title = "MailService.exe dosyasını seçin";

        //        if (openFileDialog.ShowDialog() == DialogResult.OK)
        //        {
        //            string mailServicePath = openFileDialog.FileName;
        //            string installUtilPath = @"C:\Windows\Microsoft.NET\Framework\v4.0.30319\InstallUtil.exe";

        //            if (File.Exists(mailServicePath) && File.Exists(installUtilPath))
        //            {
        //                try
        //                {
        //                    Process process = new Process();
        //                    process.StartInfo.FileName = installUtilPath;
        //                    process.StartInfo.Arguments = "\"" + mailServicePath + "\"";
        //                    process.Start();
        //                    process.WaitForExit();

        //                    if (process.ExitCode == 0)
        //                    {
        //                        MessageBox.Show("Servis başarıyla kuruldu.");
        //                    }
        //                    else
        //                    {
        //                        MessageBox.Show("Servis kurulurken bir hata oluştu.");
        //                    }
        //                }
        //                catch (Exception ex)
        //                {
        //                    MessageBox.Show("Kurulum sırasında hata oluştu: " + ex.Message);
        //                }
        //            }
        //            else
        //            {
        //                MessageBox.Show("InstallUtil.exe veya seçilen dosya bulunamadı.");
        //            }
        //        }
        //    }
        //}
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
                                MessageBox.Show("Servis başarıyla kuruldu.");
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
            try
            {
                ManagedInstallerClass.InstallHelper(new string[] { "/u", Assembly.GetExecutingAssembly().Location });
                MessageBox.Show("Servis başarıyla kaldırıldı.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kaldırma sırasında hata oluştu: " + ex.Message);
            }
        }

        private void MailSettingsForm_Load(object sender, EventArgs e)
        {
            try
            {
                MailAddress_ = MailManager.GetMailInformation("MailAddress") ?? "Mail Adresi Giriniz.";
                Password = MailManager.GetMailInformation("Password") ?? "Şifre Giriniz.";
                MailPort = MailManager.GetMailInformation("MailPort") ?? "Port Numarası Giriniz.";
                bool.TryParse(MailManager.GetMailInformation("Ssl"), out bool ssl);
                Ssl = ssl;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
