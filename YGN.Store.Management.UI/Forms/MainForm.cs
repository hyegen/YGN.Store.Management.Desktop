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
using YGN.Store.Management.Common.FormHelpers;
using YGN.Store.Management.DataAccess.Concrete.EntityFramework;
using YGN.Store.Management.Entities.Concrete;
using YGN.Store.Management.Entities.Views;
using YGN.Store.Management.UI.CommonReports;
using YGN.Store.Management.UI.DetailForms;
using YGN.Store.Management.UI.Report;

namespace YGN.Store.Management.UI.Forms
{
    public partial class MainForm : Form
    {
        #region members
        OrderManager orderManager = new OrderManager(new EfOrderDal());
        ClientManager clientManager = new ClientManager(new EfClientDal());
        BackupManager backupManager = new BackupManager(new EfBackupDal());
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
        private void modifyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHelper.ShowParametricForm<ModifyForm>(selectedId);
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
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (selectedId > 0)
            {
                DialogResult result = MessageBox.Show(string.Format("{0} numaralı siparişi silmek istediğinize emin misiniz?", selectedId), "Onayla", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in lastTransactionDataGridView.SelectedRows)
                    {
                        if (!row.IsNewRow && Convert.ToInt32(row.Cells["Id"].Value) == selectedId)
                        {
                            orderManager.DeleteOrderById(selectedId);
                            getDatas();
                            break;
                        }
                    }
                }
            }

        }
        private void lastTransactionDataGridView_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hitTestInfo = lastTransactionDataGridView.HitTest(e.X, e.Y);
                if (hitTestInfo.RowIndex >= 0)
                {
                    lastTransactionDataGridView.ClearSelection();
                    lastTransactionDataGridView.Rows[hitTestInfo.RowIndex].Selected = true;

                    int idColumnIndex = lastTransactionDataGridView.Columns["Id"].Index;
                    var idValue = lastTransactionDataGridView.Rows[hitTestInfo.RowIndex].Cells[idColumnIndex].Value;

                    if (idValue != null)
                    {
                        selectedId = Convert.ToInt32(idValue);
                    }

                    lastTransactionGridViewContextMenuStrip.Show(lastTransactionDataGridView, e.Location);
                }
            }
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

        private void btnBackup_Click(object sender, EventArgs e)
        {
            var a = backupManager.BackupDatabase();
            MessageBox.Show(string.Format(a.Message),"Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
