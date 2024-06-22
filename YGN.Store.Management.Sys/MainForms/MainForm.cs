using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using YGN.Store.Management.Common.ConfigHelpers;
using YGN.Store.Management.Common.FormHelpers;
using YGN.Store.Management.Sys.DatabaseConfigurations;
using YGN.Store.Management.Sys.MailSetting;

namespace YGN.Store.Management.Sys.MainForms
{
    public partial class MainForm : Form
    {
        #region properties
        public string ServerDescription
        {
            get { return txtServerDescription.Text; }
            set
            {
                txtServerDescription.Text = value;
            }
        }
        public string ServerUserName
        {
            get { return txtServerUserName.Text; }
            set
            {
                txtServerUserName.Text = value;
            }
        }
        public string ServerPassword
        {
            get { return txtServerPassword.Text; }
            set
            {
                txtServerPassword.Text = value;
            }
        }
        public string DatabaseDesc
        {
            get { return txtDatabaseName.Text; }
            set
            {
                txtDatabaseName.Text = value;
            }
        }
        #endregion

        #region consructor
        public MainForm()
        {
            InitializeComponent();
            CheckAndCreateConfigFile();
        }
        #endregion

        #region events
        private void btnMailSettings_Click(object sender, EventArgs e)
        {
            FormHelper.ShowForm<MailSettingsForm>();
        }
        private void btnDatabaseSettings_Click(object sender, EventArgs e)
        {
            FormHelper.ShowForm<DatabaseSetting>();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            txtIpAddress.Text = GetLocalIPv4Address();
            LoadDatabaseConfigurations();
        }
        #endregion

        #region private methods
        private void LoadDatabaseConfigurations()
        {
            try
            {
                ServerDescription = ConfigManager.GetMailInformation("ServerDescription") ?? "Sunucu Bilgisi Giriniz.";
                ServerUserName = ConfigManager.GetMailInformation("ServerUserName") ?? "Sunucu Kullanıcı Adı Giriniz.";
                ServerPassword = ConfigManager.GetMailInformation("ServerPassword") ?? "Sunucu Şifresi Giriniz.";
                DatabaseDesc = ConfigManager.GetMailInformation("DatabaseDesc") ?? "Veritabanı Açıklaması Giriniz.";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CheckAndCreateConfigFile()
        {
            string configFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "YGNConfiguration.config");

            if (!File.Exists(configFilePath))
            {
                try
                {
                    using (FileStream fs = File.Create(configFilePath))
                    {
                        using (StreamWriter writer = new StreamWriter(fs))
                        {
                            writer.WriteLine("<?xml version=\"1.0\" encoding=\"utf-8\" ?>");
                            writer.WriteLine("<configuration>");
                            writer.WriteLine("  <appSettings>");
                            writer.WriteLine("    <add key=\"MailAddress\" value=\"ornek@gmail.com\" />");
                            writer.WriteLine("    <add key=\"Password\" value=\"123\" />");
                            writer.WriteLine("    <add key=\"MailPort\" value=\"587\" />");
                            writer.WriteLine("    <add key=\"Ssl\" value=\"True\" />");
                            writer.WriteLine("  </appSettings>");
                            writer.WriteLine("</configuration>");
                        }
                    }
                    MessageBox.Show("YGNConfiguration.config dosyası oluşturuldu.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("YGNConfiguration.config dosyası oluşturulurken bir hata meydana geldi: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private string GetLocalIPv4Address()
        {
            string localIP = string.Empty;
            try
            {
                var host = Dns.GetHostEntry(Dns.GetHostName());
                foreach (var ip in host.AddressList)
                {
                    if (ip.AddressFamily == AddressFamily.InterNetwork)
                    {
                        localIP = ip.ToString();
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            return localIP;
        }
        #endregion

    }
}
