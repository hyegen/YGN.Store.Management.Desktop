using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using YGN.Store.Management.Common.FormHelpers;
using YGN.Store.Management.Sys.DatabaseConfigurations;
using YGN.Store.Management.Sys.MailSetting;

namespace YGN.Store.Management.Sys.MainForms
{
    public partial class MainForm : Form
    {
        #region members

        #endregion

        #region consructor
        public MainForm()
        {
            InitializeComponent();
        }
        #endregion

        #region events

        private void btnDatabaseSettings_Click(object sender, EventArgs e)
        {
            FormHelper.ShowForm<DatabaseSetting>();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            txtIpAddress.Text = GetLocalIPv4(NetworkInterfaceType.Ethernet);
            LoadDatabaseConfigurations();
        }
        #endregion

        #region private methods
        private void LoadDatabaseConfigurations()
        {
            txtServer.Text = ConfigurationManager.AppSettings["ServerName"] ?? "Sunucu Bulunamadı";
            txtDatabase.Text = ConfigurationManager.AppSettings["DatabaseName"] ?? "Veritabanı Bulunamadı";
            txtUsername.Text = ConfigurationManager.AppSettings["DatabaseUserName"] ?? "Veritabanı Kullanıcı Adı Bulunamadı";
            txtPassword.Text = ConfigurationManager.AppSettings["DatabasePassword"] ?? "Veritabanı Şifresi Bulunamadı";
        }
        public string GetLocalIPv4(NetworkInterfaceType _type)
        {
            string output = "";
            foreach (NetworkInterface item in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (item.NetworkInterfaceType == _type && item.OperationalStatus == OperationalStatus.Up)
                {
                    foreach (UnicastIPAddressInformation ip in item.GetIPProperties().UnicastAddresses)
                    {
                        if (ip.Address.AddressFamily == AddressFamily.InterNetwork)
                        {
                            output = ip.Address.ToString();
                        }
                    }
                }
            }
            return output;
        }
        #endregion

        private void btnMailSettings_Click(object sender, EventArgs e)
        {
            FormHelper.ShowForm<MailSettingsForm>();
        }
    }
}
