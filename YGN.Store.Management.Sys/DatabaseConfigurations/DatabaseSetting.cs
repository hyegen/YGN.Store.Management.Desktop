using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YGN.Store.Management.Common.ConfigHelpers;

namespace YGN.Store.Management.Sys.DatabaseConfigurations
{
    public partial class DatabaseSetting : Form
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
        public string DatabaseUserName
        {
            get { return txtServerUserName.Text; }
            set
            {
                txtServerUserName.Text = value;
            }
        }
        public string DatabasePassword
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
        public string BackupFolderPath
        {
            get { return txtBackupDatabaseFolderPath.Text; }
            set
            {
                txtBackupDatabaseFolderPath.Text = value;
            }
        }
        #endregion

        #region constructor
        public DatabaseSetting()
        {
            InitializeComponent();
        }
        #endregion

        #region events
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                ConfigManager.SaveDatabaseInformations("ServerDescription", ServerDescription);
                ConfigManager.SaveDatabaseInformations("DatabaseUserName", DatabaseUserName);
                ConfigManager.SaveDatabaseInformations("DatabasePassword", DatabasePassword);
                ConfigManager.SaveDatabaseInformations("DatabaseDesc", DatabaseDesc);
                ConfigManager.SaveDatabaseInformations("BackupFolderPath", BackupFolderPath);

                MessageBox.Show("Sunucu ve Veritabanı Bilgileri başarıyla Configuration dosyasına kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        private void DatabaseSetting_Load(object sender, EventArgs e)
        {
            LoadDatabaseConfigurations();
        }
        private void LoadDatabaseConfigurations()
        {
            try
            {
                ServerDescription = ConfigManager.GetMailInformation("ServerDescription") ?? "Sunucu Bilgisi Giriniz.";
                DatabaseUserName = ConfigManager.GetMailInformation("DatabaseUserName") ?? "Sunucu Kullanıcı Adı Giriniz.";
                DatabasePassword = ConfigManager.GetMailInformation("DatabasePassword") ?? "Sunucu Şifresi Giriniz.";
                DatabaseDesc = ConfigManager.GetMailInformation("DatabaseDesc") ?? "Veritabanı Açıklaması Giriniz.";
                BackupFolderPath = ConfigManager.GetMailInformation("BackupFolderPath") ?? "Veritabanı Yedekleme Yolu Giriniz.";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
