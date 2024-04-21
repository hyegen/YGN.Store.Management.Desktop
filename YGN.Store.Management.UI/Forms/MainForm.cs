using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
using YGN.Store.Management.UI.CommonReports;
using YGN.Store.Management.UI.DetailForms;
using YGN.Store.Management.UI.Helper;
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
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Process.GetCurrentProcess().Kill();
        }
        private void btnStockAmount_Click(object sender, EventArgs e)
        {
            FormHelper.ShowForm<StockAmountForm>();
        }
        private void btnQuickSales_Click(object sender, EventArgs e)
        {
            FormHelper.ShowForm<QuickSalesOrderDetailForm>();
        }
        private void btnPurchasing_Click(object sender, EventArgs e)
        {
            FormHelper.ShowForm<PurchasingOrderDetailForm>();
        }
        private void btnCreateOrderSlip_Click(object sender, EventArgs e)
        {
            FormHelper.ShowForm<PrintOrderSlip>();
        }
        private void btnClients_Click(object sender, EventArgs e)
        {
            FormHelper.ShowForm<ClientsForm>();
        }
        private void btnProducts_Click(object sender, EventArgs e)
        {
            FormHelper.ShowForm<ItemsForm>();
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            getDatas();
        }
        private void lastTransactionDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int selectedID = Convert.ToInt32(lastTransactionDataGridView.Rows[e.RowIndex].Cells["Id"].Value);
                ShowDetailForm(selectedID);
            }
        }

        #endregion

        #region private methods

        private void getDatas()
        {
            lastTransactionDataGridView.DataSource = orderManager.GetOrderLineViews();
        }
        private void ShowDetailForm(int selectedID)
        {
            FormHelper.ShowParametricForm<InformationsForm>(selectedID);
        }

        #endregion




    }
}
