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
                ConfigManager.SaveDatabaseInformations("ServerUserName", ServerUserName);
                ConfigManager.SaveDatabaseInformations("ServerPassword", ServerPassword);
                ConfigManager.SaveDatabaseInformations("DatabaseDesc", DatabaseDesc);

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
    }
}
