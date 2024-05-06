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
using YGN.Store.Management.Common.TransactionCodes;
using YGN.Store.Management.DataAccess.Concrete.EntityFramework;
using YGN.Store.Management.Entities.Concrete;
using YGN.Store.Management.Entities.Views;

namespace YGN.Store.Management.UI.CommonReports
{
    public partial class ModifyForm : Form
    {
        #region members
        private List<SelectedItemsInOrder> selectedItems = new List<SelectedItemsInOrder>();
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
        #endregion

        #region private methods
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
            selectedItems = orderManager.GetSelectedItemsInOrder(selectedOrderId);
            selectedItemsDataGridView.DataSource = selectedItems;
            decimal totalPrice = orderManager.GetTotalPriceForOrderInformationPrice(selectedOrderId);
            string formattedTotalPrice = totalPrice.ToString("#,##0");
            txtLastPrice.Text = formattedTotalPrice + " TL";
        }
        #endregion

        private void btnDeleteLine_Click(object sender, EventArgs e)
        {
            if (selectedItemsDataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = selectedItemsDataGridView.SelectedRows[0];

                string selectedItemCode = (selectedRow.Cells["ItemCode"].Value).ToString();

                var itemToRemove = selectedItems.FirstOrDefault(item => item.ItemCode == selectedItemCode);
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            updateOrder();
        }

        private void updateOrder()
        {
            Order newOrder = new Order
            {
                DateTime = DateTime.Now,
                TotalPrice = 0,
                OrderLines = new List<OrderLine>(),
                IOCode = (int)InputOutputCodes.Output
            };

            foreach (DataGridViewRow row in selectedItemsDataGridView.Rows)
            {
                int itemId = Convert.ToInt32(row.Cells["OrderId"].Value);
                //string itemId = (string)row.Cells["OrderId"].Value;
                int selectItemId = itemManager.GetItemIdByOrderId(itemId);

                int amount = Convert.ToInt32(row.Cells["Amount"].Value);

                OrderLine newOrderLine = new OrderLine
                {
                    ItemId = selectItemId,
                    Amount = amount,
                    DateTime = DateTime.Now,
                    LineTotal = CalculateTotalPrice(selectItemId, amount),
                    Order = newOrder,
                    IOCode = (int)InputOutputCodes.Output
                };

                newOrder.TotalPrice += newOrderLine.LineTotal;
                newOrder.OrderLines.Add(newOrderLine);
            }

            if (newOrder.OrderLines.Count > 0 && newOrder.TotalPrice != 0)
            {
                newOrder.ClientId = GetClientFromCombobox();
                orderManager.UpdateOrder(newOrder);
                MessageBox.Show("Sipariş Güncelleme İşlemi Başarılı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Güncelleme İşlemi Başarısız Miktar Girişi Yapınız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
    }
}
