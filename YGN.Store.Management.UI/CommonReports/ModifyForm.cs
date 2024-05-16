using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YGN.Store.Management.Business.Concrete;
using YGN.Store.Management.Common.TransactionCodes;
using YGN.Store.Management.DataAccess.Concrete.EntityFramework;
using YGN.Store.Management.Entities.Concrete;
using YGN.Store.Management.Entities.Views;

namespace YGN.Store.Management.UI.CommonReports
{
    public partial class ModifyForm : Form
    {
        #region members
        //private List<SelectedItemsInOrder> selectedItems = new List<SelectedItemsInOrder>();
        private List<SelectedItems> selectedItemsTest = new List<SelectedItems>();
        ItemManager itemManager = new ItemManager(new EfItemDal());
        OrderManager orderManager = new OrderManager(new EfOrderDal());
        ClientManager clientManager = new ClientManager(new EfClientDal());
        private int selectedOrderId;
        private List<Client> allClients;
        #endregion

        #region constructor
        public ModifyForm(int selectedOrderId)
        {
            InitializeComponent();
            this.selectedOrderId = selectedOrderId;
            getDatas();
        }
        #endregion

        #region events
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void comboBoxClients_DropDown(object sender, EventArgs e)
        {
            comboBoxClients.DataSource = allClients;
        }
        private void btnDeleteLine_Click(object sender, EventArgs e)
        {
            if (selectedItemsDataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = selectedItemsDataGridView.SelectedRows[0];

                int selectedItemId = Convert.ToInt32(selectedRow.Cells["ItemId"].Value);

                var itemToRemove = selectedItemsTest.FirstOrDefault(item => item.ItemId == selectedItemId);
                if (itemToRemove != null)
                {
                    selectedItemsTest.Remove(itemToRemove);
                    selectedItemsDataGridView.DataSource = null;
                    selectedItemsDataGridView.DataSource = selectedItemsTest;
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
        private void btnSave_Click(object sender, EventArgs e)
        {
            UpdateOrder(selectedOrderId);
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
                // decimal unitPrice = Convert.ToDecimal(selectedRow.Cells["UnitPrice"].Value);
                //   string brand = selectedRow.Cells["Brand"].Value?.ToString();

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
                    selectedItemsTest.Add(new SelectedItems { ItemId = id, ItemCode = itemCode, ItemName = itemName, Amount = 0, LineTotal = 0 });
                    RefreshSelectedOrdersDataGridView();
                }
                else
                {
                    MessageBox.Show("Bu ürün zaten seçilmiş.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private void selectedItemsDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == selectedItemsDataGridView.Columns["Amount"].Index && e.RowIndex >= 0)
            {
                int id = Convert.ToInt32(selectedItemsDataGridView.Rows[e.RowIndex].Cells["ItemId"].Value);
                int amount = Convert.ToInt32(selectedItemsDataGridView.Rows[e.RowIndex].Cells["Amount"].Value);
                double unitPrice = itemManager.GetUnitPrice(id);

                decimal totalPrice = (decimal)(amount * unitPrice);

                selectedItemsDataGridView.Rows[e.RowIndex].Cells["LineTotal"].Value = totalPrice;
                UpdateTotalPriceTextBox();
            }
        }
        #endregion

        #region private methods
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
        private void getDatas()
        {
            itemsDataGridView.DataSource = itemManager.GetItems();
            FillComboBox(selectedOrderId);
            getSelectedItems();
        }
        private void FillComboBox(int orderId = -1)
        {

            allClients = clientManager.GetAllClientsByNameAndSurname();
            int selectedClient = clientManager.GetClientIdByOrderId(orderId);

            comboBoxClients.DataSource = allClients;
            comboBoxClients.DisplayMember = "ClientCodeAndClientName";
            comboBoxClients.ValueMember = "Id";

            if (orderId != -1)
            {
                comboBoxClients.SelectedValue = selectedClient;
            }
            else
            {
                comboBoxClients.SelectedIndex = -1;
            }
        }
        private void getSelectedItems()
        {
            //selectedItemsDataGridView.DataSource = orderManager.GetOrderDetailInformation(selectedOrderId);
            //selectedItems = orderManager.GetSelectedItemsInOrder(selectedOrderId);
            //selectedItemsTest = orderManager.GetSelectedItemsInOrder(selectedOrderId);
            //selectedItemsDataGridView.DataSource = selectedItems;
            selectedItemsTest = orderManager.GetSelectedItemsInOrderTest(selectedOrderId);
            selectedItemsDataGridView.DataSource = selectedItemsTest;
            decimal totalPrice = orderManager.GetTotalPriceForOrderInformationPrice(selectedOrderId);
            string formattedTotalPrice = totalPrice.ToString("#,##0");
            txtLastPrice.Text = formattedTotalPrice + " TL";
        }
        private void UpdateOrder(int orderId)
        {
            Order existingOrder = orderManager.GetOrderById(orderId);

            if (existingOrder != null)
            {
                existingOrder.DateTime = DateTime.Now;
                existingOrder.TotalPrice = 0;
                existingOrder.OrderLines.Clear();

                foreach (DataGridViewRow row in selectedItemsDataGridView.Rows)
                {
                    int selectItemId = (int)row.Cells["ItemId"].Value;
                    int amount = (int)(row.Cells["Amount"].Value);
                    int selectedOrderLineId = (int)row.Cells["OrderLineId"].Value;

                    OrderLine newOrderLine = new OrderLine
                    {
                        Id = selectedOrderLineId,
                        ItemId = selectItemId,
                        Amount = amount,
                        DateTime = DateTime.Now,
                        LineTotal = CalculateTotalPrice(selectItemId, amount),
                        OrderId = existingOrder.Id,
                        IOCode = existingOrder.IOCode
                    };

                    existingOrder.TotalPrice += newOrderLine.LineTotal;
                    existingOrder.OrderLines.Add(newOrderLine);
                }

                if (existingOrder.OrderLines.Count > 0 && existingOrder.TotalPrice != 0)
                {
                    existingOrder.ClientId = GetClientFromCombobox();
                    orderManager.UpdateOrder(existingOrder);
                    MessageBox.Show("Sipariş Güncelleme İşlemi Başarılı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    orderManager.DeleteOrder(existingOrder);
                    MessageBox.Show("Sipariş silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Sipariş bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private decimal CalculateTotalPrice(int itemId, int amount)
        {
            var unitPrice = itemManager.GetUnitPrice(itemId);
            return (decimal)(unitPrice * amount);
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
        private void RefreshSelectedOrdersDataGridView()
        {
            selectedItemsDataGridView.DataSource = null;
            selectedItemsDataGridView.DataSource = selectedItemsTest;
        }
        #endregion

    }
}