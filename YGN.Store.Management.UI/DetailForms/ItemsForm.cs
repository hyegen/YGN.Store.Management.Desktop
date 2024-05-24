using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YGN.Store.Management.Business.FluentValidation;
using YGN.Store.Management.Entities.Concrete;
using FluentValidation.Results;
using ValidationResult = FluentValidation.Results.ValidationResult;
using FluentValidation;
using YGN.Store.Management.Business.Concrete;
using YGN.Store.Management.DataAccess.Concrete.EntityFramework;

namespace YGN.Store.Management.UI.DetailForms
{
    public partial class ItemsForm : Form
    {
        #region members
        ItemManager manager = new ItemManager(new EfItemDal());
        private DataTable dataTable;
        private bool anyChangesMade = false;
        #endregion

        #region properties
        private string ItemCode
        {
            get { return txtItemCode.Text; }
            set
            {
                txtItemCode.Text = value;
            }
        }
        private string ItemDescription
        {
            get { return txtItemDescription.Text; }
            set
            {
                txtItemDescription.Text = value;
            }
        }
        private double ItemUnitPrice
        {
            get
            {
                if (string.IsNullOrEmpty(txtUnitPrice.Text))
                {
                    return 0;
                }
                else
                {
                    return Convert.ToDouble(txtUnitPrice.Text);
                }
            }
            set
            {
                txtUnitPrice.Text = value.ToString();
            }
        }
        #endregion

        #region constructor
        public ItemsForm()
        {
            InitializeComponent();
            getData();
            getNumberOfItemsCount();
            this.WindowState = FormWindowState.Maximized;
        }
        #endregion

        #region events
        private void btnAddItem_Click(object sender, EventArgs e)
        {
            var item = new Item
            {
                ItemCode = ItemCode,
                ItemName = ItemDescription,
                UnitPrice = ItemUnitPrice
            };
            ItemValidator itemValidator = new ItemValidator();
            ValidationResult result = itemValidator.Validate(item);
            if (result.IsValid)
            {
                bool isOk = manager.AddItem(item);
                getData();
                getNumberOfItemsCount();
                if (isOk)
                {
                    MessageBox.Show("Ürün Başarıyla Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Ürün Eklenemedi. Aynı Ürün Koda sahip bir ürün zaten var ise tekrar kontrol ediniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Ürün Kodu ve/veya Ürün Adı Boş Bırakılamaz..", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            getData();
        }
        private void itemsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtItemCode.Text = itemsDataGridView.CurrentRow.Cells[1].Value?.ToString() ?? "";
            txtItemDescription.Text = itemsDataGridView.CurrentRow.Cells[2].Value?.ToString() ?? "";
            txtUnitPrice.Text = itemsDataGridView.CurrentRow.Cells[3].Value?.ToString() ?? "";
        }
        private void btnUpdateItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtItemCode.Text) || string.IsNullOrEmpty(txtItemDescription.Text))
            {
                MessageBox.Show("Güncellenecek Cari Seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    var getId = Convert.ToInt32(itemsDataGridView.CurrentRow.Cells[0].Value);
                    var item = new Item
                    {
                        Id = getId,
                        ItemCode = ItemCode,
                        ItemName = ItemDescription,
                        UnitPrice = ItemUnitPrice
                    };
                    manager.UpdateItem(item);
                    MessageBox.Show("Güncelleme Başarılı !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    getData();
                }
                catch
                {
                    MessageBox.Show("Güncelleme yapılırken bir hata oluştu. Hüseyin ile görüşünüz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtItemCode.Text) || string.IsNullOrEmpty(txtItemDescription.Text))
            {
                MessageBox.Show("Silinecek Cari Seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    var getId = Convert.ToInt32(itemsDataGridView.CurrentRow.Cells[0].Value);
                    string getItemCode = itemsDataGridView.CurrentRow.Cells[1].Value.ToString();
                    string getDescription = itemsDataGridView.CurrentRow.Cells[2].Value.ToString();
                    DialogResult dialogResult = MessageBox.Show(string.Format("{0} Kodlu, {1}  Adlı Ürünü silmek istediğinize emin misiniz?", getItemCode, getDescription), "Sil", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        var item = new Item
                        {
                            Id = getId,
                            ItemCode = ItemCode,
                            ItemName = ItemDescription,
                        };
                        manager.DeleteItem(item);
                        MessageBox.Show("Silme Başarılı !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        getData();
                    }
                }
                catch
                {
                    MessageBox.Show("Silme işlemi yapılırken bir hata oluştu. Hüseyin ile görüşünüz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void ItemsForm_Load(object sender, EventArgs e)
        {
            LoadItems();
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).TextChanged += txt_TextChanged;
                }
            }
        }
        private void txt_TextChanged(object sender, EventArgs e)
        {
            anyChangesMade = true;
        }
        private void txtSearchItem_TextChanged(object sender, EventArgs e)
        {
            string searchWord = txtSearchItem.Text.ToLower();
            DataView dv = new DataView(dataTable);
            dv.RowFilter = string.Format("[Ürün Kodu] LIKE '%{0}%' OR CONVERT(Id, 'System.String') LIKE '%{0}%' OR [Malzeme Açıklaması] LIKE '%{0}%' OR [Marka] LIKE '%{0}%'", searchWord);
            itemsDataGridView.DataSource = dv;
        }
        #endregion

        #region private methods
        private void getData()
        {
            itemsDataGridView.DataSource = manager.GetItems();
        }
        private void getNumberOfItemsCount()
        {
            lblCountOfItems.Text = manager.CountOfAllItems().ToString();
            lblCountOfItems.Visible = true;
        }
        private void LoadItems()
        {
            var items = manager.GetItems();

            dataTable = new DataTable();
            dataTable.Columns.Add("Id", typeof(int));
            dataTable.Columns.Add("Ürün Kodu", typeof(string));
            dataTable.Columns.Add("Malzeme Açıklaması", typeof(string));
            dataTable.Columns.Add("Birim Fiyat", typeof(double));
            dataTable.Columns.Add("Marka", typeof(string));
            dataTable.Columns.Add("colAmount", typeof(int));

            foreach (var item in items)
            {
                dataTable.Rows.Add(item.Id, item.ItemCode, item.ItemName, item.UnitPrice, item.Brand);
            }

            itemsDataGridView.DataSource = dataTable;
        }

        #endregion

    }
}
