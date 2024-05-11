﻿using System;
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
            //selectedItems = orderManager.GetSelectedItemsInOrder(selectedOrderId);
            //selectedItemsTest = orderManager.GetSelectedItemsInOrder(selectedOrderId);
            //selectedItemsDataGridView.DataSource = selectedItems;
            selectedItemsTest = orderManager.GetSelectedItemsInOrderTest(selectedOrderId);
            selectedItemsDataGridView.DataSource = selectedItemsTest;
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
            UpdateOrder(selectedOrderId);
            this.Close();
        }
        /* private void updateOrder()
         {
             var getId = selectedOrderId;
             Order newOrder = new Order
             {
                 Id = getId,
                 DateTime = DateTime.Now,
                 TotalPrice = 0,
                 OrderLines = new List<OrderLine>(),
                 IOCode = (int)InputOutputCodes.Output
             };

             foreach (DataGridViewRow row in selectedItemsDataGridView.Rows)
             {
                 int orderId = selectedOrderId;
                 //string itemId = (string)row.Cells["OrderId"].Value;
                 //int selectItemId = itemManager.GetItemIdByOrderId(orderId);
                 int selectItemId = (int)row.Cells["ItemId"].Value;

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
                 //orderManager.UpdateOrder(newOrder);
             }
             else
             {
                 orderManager.DeleteOrder(newOrder);
             }
             MessageBox.Show("Sipariş Güncelleme İşlemi Başarılı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
         }*/

        private void UpdateOrder(int orderId)
        {
            Order existingOrder = orderManager.GetOrderById(orderId); // Get the existing order from the database

            if (existingOrder != null)
            {
                // Update the properties of the existing order
                existingOrder.DateTime = DateTime.Now;
                existingOrder.TotalPrice = 0; // Reset the total price
                existingOrder.OrderLines.Clear(); // Clear existing order lines

                foreach (DataGridViewRow row in selectedItemsDataGridView.Rows)
                {
                    int selectItemId = (int)row.Cells["ItemId"].Value;
                    int amount = Convert.ToInt32(row.Cells["Amount"].Value);

                    int orderId2 = existingOrder.Id;

                    OrderLine newOrderLine = new OrderLine
                    {
                        ItemId = selectItemId,
                        Amount = amount,
                        DateTime = DateTime.Now,
                        LineTotal = CalculateTotalPrice(selectItemId, amount),
                        OrderId = orderId2, // Doğru şekilde ilişkilendirin
                        IOCode = (int)InputOutputCodes.Output
                    };

                    existingOrder.TotalPrice += newOrderLine.LineTotal;
                    existingOrder.OrderLines.Add(newOrderLine);
                }

                if (existingOrder.OrderLines.Count > 0 && existingOrder.TotalPrice != 0)
                {
                    existingOrder.ClientId = GetClientFromCombobox();
                    orderManager.UpdateOrder(existingOrder); // Update the order in the database
                    MessageBox.Show("Sipariş Güncelleme İşlemi Başarılı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    orderManager.DeleteOrder(existingOrder); // Delete the order if there are no order lines or total price is zero
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
    }
}
