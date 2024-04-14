using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YGN.Store.Management.UI.DetailForms;

namespace YGN.Store.Management.UI.Forms
{
    public partial class MainForm : Form
    {
        #region constructor
        public MainForm()
        {
            InitializeComponent();
        }
        #endregion

        #region events
        private void btnClients_Click(object sender, EventArgs e)
        {
            ClientsForm clientsForm = new ClientsForm();
            clientsForm.ShowDialog();
        }
        private void btnProducts_Click(object sender, EventArgs e)
        {
            ItemsForm itemsForm = new ItemsForm();
            itemsForm.ShowDialog();
        }
        private void btnQuickSales_Click(object sender, EventArgs e)
        {
            QuickSalesOrderDetailForm detailForm = new QuickSalesOrderDetailForm();
            detailForm.ShowDialog();
        }
        #endregion


    }
}
