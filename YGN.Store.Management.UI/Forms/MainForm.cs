using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YGN.Store.Management.Business.Concrete;
using YGN.Store.Management.DataAccess.Concrete.EntityFramework;
using YGN.Store.Management.Entities.Concrete;
using YGN.Store.Management.Entities.Views;
using YGN.Store.Management.UI.DetailForms;
using YGN.Store.Management.UI.Report;

namespace YGN.Store.Management.UI.Forms
{
    public partial class MainForm : Form
    {
        #region members
        OrderManager orderManager = new OrderManager(new EfOrderDal());
        #endregion

        #region constructor
        public MainForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            getDatas();
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
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            getDatas();
        }

        private void btnPurchasing_Click(object sender, EventArgs e)
        {
            PurchasingOrderDetailForm purchasingOrderDetailForm = new PurchasingOrderDetailForm();
            purchasingOrderDetailForm.ShowDialog();
        }
        private void lastTransactionDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int selectedID = Convert.ToInt32(lastTransactionDataGridView.Rows[e.RowIndex].Cells["Id"].Value);
                ShowDetailForm(selectedID);
            }
        }

        private void btnCreateOrderSlip_Click(object sender, EventArgs e)
        {
            PrintOrderSlip printOrderSlip = new PrintOrderSlip();
            printOrderSlip.Show();
        }

        #endregion

        #region private methods

        private void getDatas()
        {
            lastTransactionDataGridView.DataSource = orderManager.GetOrderLineViews();
        }
        private void ShowDetailForm(int selectedID)
        {
            InformationsForm detailForm = new InformationsForm(selectedID);
            detailForm.ShowDialog();
        }
        #endregion


    }
}
