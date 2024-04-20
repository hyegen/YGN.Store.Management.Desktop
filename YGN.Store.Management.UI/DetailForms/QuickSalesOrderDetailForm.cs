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
using YGN.Store.Management.Common.TransactionCodes;
using YGN.Store.Management.DataAccess.Concrete.EntityFramework;
using YGN.Store.Management.Entities.Concrete;
using YGN.Store.Management.Entities.Views;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace YGN.Store.Management.UI.DetailForms
{
    public partial class QuickSalesOrderDetailForm : Form
    {
        #region members
        private List<SelectedItems> selectedItems = new List<SelectedItems>();
        ItemManager itemManager = new ItemManager(new EfItemDal());
        OrderManager orderManager = new OrderManager(new EfOrderDal());
        ClientManager clientManager = new ClientManager(new EfClientDal());
        #endregion

        #region constructor
        public QuickSalesOrderDetailForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            getDatas();
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
                //decimal unitPrice = Convert.ToDecimal(selectedRow.Cells["UnitPrice"].Value);
                //string brand = selectedRow.Cells["Brand"].Value?.ToString();

                bool isDuplicate = false;
                foreach (DataGridViewRow row in selectedItemsDataGridView.Rows)
                {
                    //if (row.Cells["ItemId"].Value != null && Convert.ToInt32(row.Cells["ItemId"].Value) == id)
                    //{
                    //    isDuplicate = true;
                    //    break;
                    //}
                    if (row.Cells["ItemId"].Value != null && Convert.ToInt32(row.Cells["ItemId"].Value) == id)
                    {
                        isDuplicate = true;
                        break;
                    }
                }

                if (!isDuplicate)
                {
                    //selectedOrders.Add(new OrderLine { Id = id, ItemId = id, Amount = 0, DateTime = DateTime.Now, LineTotal = 0 });
                    selectedItems.Add(new SelectedItems { ItemId = id, ItemCode = itemCode, ItemName = itemName, Amount = 0, LineTotal = 0 });
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
            createOrder();

            this.Close();
        }
        private void selectedItemsDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(selectedItemsDataGridView.Rows[e.RowIndex].Cells["ItemId"].Value);
            int amount = Convert.ToInt32(selectedItemsDataGridView.Rows[e.RowIndex].Cells["Amount"].Value);
            double unitPrice = itemManager.GetUnitPrice(id);

            decimal totalPrice = (decimal)(amount * unitPrice);

            if (selectedItemsDataGridView.Rows[e.RowIndex].Cells["LineTotal"].Value != null)
            {
                selectedItemsDataGridView.Rows[e.RowIndex].Cells["LineTotal"].Value = totalPrice;
            }
            else
            {
                selectedItemsDataGridView.Rows[e.RowIndex].Cells["LineTotal"].Value = 0; // Veya istediğiniz varsayılan bir değer
            }
            UpdateTotalPriceTextBox();
        }
        private void btnDeleteLine_Click(object sender, EventArgs e)
        {
            if (selectedItemsDataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = selectedItemsDataGridView.SelectedRows[0];

                int selectedId = Convert.ToInt32(selectedRow.Cells["ItemId"].Value);

                var itemToRemove = selectedItems.FirstOrDefault(item => item.ItemId == selectedId);
                if (itemToRemove != null)
                {
                    selectedItems.Remove(itemToRemove);
                    selectedItemsDataGridView.DataSource = null;
                    selectedItemsDataGridView.DataSource = selectedItems;
                    selectedItemsDataGridView.Refresh();
                    UpdateTotalPriceTextBox();
                }
                else
                {
                    MessageBox.Show("Silme işlemi başarısız oldu.");
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz bir satırı seçin.");
            }
        }
        #endregion

        #region private methods
        private void RefreshSelectedOrdersDataGridView()
        {
            selectedItemsDataGridView.DataSource = null;
            selectedItemsDataGridView.DataSource = selectedItems;
        }
        private void getDatas()
        {
            itemsDataGridView.DataSource = itemManager.GetItems();
            FillComboBox();
        }
        private decimal CalculateTotalPrice(int itemId, int amount)
        {
            var unitPrice = itemManager.GetUnitPrice(itemId);
            return (decimal)(unitPrice * amount);
        }
        private void createOrder()
        {
            Order newOrder = new Order
            {
                DateTime = DateTime.Now,
                TotalPrice = 0,
                OrderLines = new List<OrderLine>(),
                TransactionCode = (int)TransactionCodes.Output
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
                    Order = newOrder,
                    TransactionCode = (int)TransactionCodes.Output
                };

                newOrder.TotalPrice += newOrderLine.LineTotal;
                newOrder.OrderLines.Add(newOrderLine);
            }

            if (newOrder.OrderLines.Count > 0 && newOrder.TotalPrice != 0)
            {
                newOrder.ClientId = GetClientFromCombobox();
                orderManager.AddOrder(newOrder);
                MessageBox.Show("Satış İşlemi Başarılı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Satış İşlemi Başarısız Miktar Girişi Yapınız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
        private void FillComboBox()
        {
            List<Client> clients = clientManager.GetAllClientsByNameAndSurname();
            comboBoxClients.DataSource = clients;
            comboBoxClients.DisplayMember = "ClientNameSurname";
            comboBoxClients.ValueMember = "Id";
        }
        private int GetClientFromCombobox()
        {
            if (comboBoxClients.SelectedItem is Client selectedClient)
            {
                return selectedClient.Id;
            }
            else
            {
                return -1;
            }
        }

        #endregion

    }
}
