using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YGN.Store.Management.Business.Concrete;
using YGN.Store.Management.Common.FormHelpers;
using YGN.Store.Management.DataAccess.Concrete.EntityFramework;

namespace YGN.Store.Management.UI.Forms
{
    public partial class LoginForm : Form
    {
        #region members
        UserManager userManager = new UserManager(new EfUserDal());
        #endregion

        #region constructor
        public LoginForm()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';
        }
        #endregion

        #region properties
        public string UserName
        {
            get { return usersCombobox.Text; }
            set
            {
                usersCombobox.Text = value;
            }
        }
        public string Password
        {
            get { return txtPassword.Text; }
            set
            {
                txtPassword.Text = value;
            }
        }
        #endregion

        #region events
        private void LoginForm_Load(object sender, EventArgs e)
        {
            usersCombobox.DataSource = userManager.GetAllUsers();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login();
            }
        }
        #endregion

        #region private methods
        private void Login()
        {
            bool isTrue = userManager.Login(UserName, Password);
            if (isTrue)
            {
                FormHelper.ShowForm<MainForm>();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Şifre Hatalı !", "Hata", MessageBoxButtons.RetryCancel);
            }
        }
        #endregion

    }
}
