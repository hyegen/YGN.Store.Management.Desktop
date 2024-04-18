using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using YGN.Store.Management.Business.Concrete;
using YGN.Store.Management.DataAccess.Concrete.EntityFramework;
using YGN.Store.Management.Entities.Concrete;

namespace YGN.Store.Management.UI.DetailForms
{
    public partial class QuickSalesOrderDetailForm : Form
    {
        #region members
        private List<OrderLine> selectedOrders = new List<OrderLine>();
        ItemManager itemManager = new ItemManager(new EfItemDal());
        OrderLineManager orderLineManager = new OrderLineManager(new EfOrderLineDal());
        OrderManager orderManager = new OrderManager(new EfOrderDal());
        #endregion

        #region constructor
        public QuickSalesOrderDetailForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            getDataForItemsGrid();
        }

        #endregion

        #region events
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void itemsDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = itemsDataGridView.Rows[e.RowIndex];

                int id = Convert.ToInt32(selectedRow.Cells["Id"].Value);
                string itemCode = selectedRow.Cells["ItemCode"].Value.ToString();
                string itemName = selectedRow.Cells["ItemName"].Value.ToString();
                decimal unitPrice = Convert.ToDecimal(selectedRow.Cells["UnitPrice"].Value);
                string brand = selectedRow.Cells["Brand"].Value?.ToString();

                bool isDuplicate = false;
                foreach (DataGridViewRow row in selectedItemsDataGridView.Rows)
                {
                    if (row.Cells["ItemId"].Value != null && Convert.ToInt32(row.Cells["ItemId"].Value) == id)
                    {
                        isDuplicate = true;
                        break;
                    }
                }

                if (!isDuplicate)
                {
                    selectedOrders.Add(new OrderLine { Id = id, ItemId = id, Amount = 0, DateTime = DateTime.Now, LineTotal = 0 });
                    RefreshSelectedOrdersDataGridView();
                }
                else
                {
                    MessageBox.Show("Bu ürün zaten seçilmiş.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (createOrder())
                MessageBox.Show("Satış İşlemi Başarılı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Satış İşlemi Başarısız.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            this.Close();
        }
        private void selectedItemsDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == selectedItemsDataGridView.Columns["Amount"].Index && e.RowIndex >= 0)
            {
                int id = Convert.ToInt32(selectedItemsDataGridView.Rows[e.RowIndex].Cells["Id"].Value);
                int amount = Convert.ToInt32(selectedItemsDataGridView.Rows[e.RowIndex].Cells["Amount"].Value);
                double unitPrice = itemManager.GetUnitPrice(id);

                decimal totalPrice = (decimal)(amount * unitPrice);

                selectedItemsDataGridView.Rows[e.RowIndex].Cells["LineTotal"].Value = totalPrice;
                UpdateTotalPriceTextBox();
            }
        }

        #endregion

        #region private methods
        private void RefreshSelectedOrdersDataGridView()
        {
            selectedItemsDataGridView.DataSource = null;
            selectedItemsDataGridView.DataSource = selectedOrders;
        }

        private void getDataForItemsGrid()
        {
            itemsDataGridView.DataSource = itemManager.GetItems();
        }
        private decimal CalculateTotalPrice(int itemId, int amount)
        {
            var unitPrice = itemManager.GetUnitPrice(itemId);
            return (decimal)(unitPrice * amount);
        }
        private bool createOrder()
        {
            Order newOrder = new Order
            {
                DateTime = DateTime.Now,
                TotalPrice = 0,
                OrderLines = new List<OrderLine>()
            };

            foreach (DataGridViewRow row in selectedItemsDataGridView.Rows)
            {
                int itemId = Convert.ToInt32(row.Cells["ItemId"].Value);
                int amount = Convert.ToInt32(row.Cells["Amount"].Value);

                OrderLine newOrderLine = new OrderLine
                {
                    ItemId = itemId,

                    Amount = amount,
                    DateTime = DateTime.Now,
                    LineTotal = CalculateTotalPrice(itemId, amount),
                    Order = newOrder
                };

                newOrder.TotalPrice += newOrderLine.LineTotal;
                newOrder.OrderLines.Add(newOrderLine);
            }

            if (newOrder.OrderLines.Count > 0 || newOrder.OrderLines.Any(x => x.Amount > 0))
            {
                orderManager.AddOrder(newOrder);
                return true;
            }
            else
            {
                return false;
            }
        }
        private void UpdateTotalPriceTextBox()
        {
            decimal total = 0;
            foreach (DataGridViewRow row in selectedItemsDataGridView.Rows)
            {
                if (!row.IsNewRow)
                {
                    total += Convert.ToDecimal(row.Cells["LineTotal"].Value);
                }
            }
            txtLastPrice.Text = total.ToString();
        }

        #endregion
    }
}
