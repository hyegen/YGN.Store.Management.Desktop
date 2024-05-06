using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
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
        ClientManager clientManager = new ClientManager(new EfClientDal());
        private int selectedId;
        #endregion

        #region constructor
        public MainForm()
        {
            InitializeComponent();
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
            FormHelper.ShowParametricForm<PrintOrderSlip>(selectedId);
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
                ShowDetailForm();
            }
        }
        private void lastTransactionDataGridView_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                lastTransactionGridViewContextMenuStrip.Show(Cursor.Position);
            }
        }
        private void lastTransactionGridViewContextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            Point point = lastTransactionDataGridView.PointToClient(Cursor.Position);
            int rowIndex = lastTransactionDataGridView.HitTest(point.X, point.Y).RowIndex;

            if (rowIndex > -1)
            {
                selectedId = Convert.ToInt32(lastTransactionDataGridView.Rows[rowIndex].Cells["Id"].Value);
            }
            else
            {
                e.Cancel = true;
            }
        }
        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (selectedId == null || selectedId == 0)
                MessageBox.Show("Bir şeyler ters gitti", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                FormHelper.ShowParametricForm<PrintOrderSlip>(selectedId);
        }
        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowDetailForm();
        }
        #endregion

        #region private methods

        private void getDatas()
        {
            lastTransactionDataGridView.DataSource = orderManager.GetOrderLineViews();
        }
        private void ShowDetailForm()
        {
            FormHelper.ShowParametricForm<InformationsForm>(selectedId);
        }

        #endregion

        private void modifyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHelper.ShowParametricForm<ModifyForm>(selectedId);
        }
    }
}
