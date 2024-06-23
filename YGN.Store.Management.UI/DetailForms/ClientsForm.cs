using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YGN.Store.Management.Business.Concrete;
using YGN.Store.Management.Business.FluentValidation;
using YGN.Store.Management.DataAccess.Concrete.EntityFramework;
using YGN.Store.Management.Entities.Concrete;
using FluentValidation.Results;
using ValidationResult = FluentValidation.Results.ValidationResult;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;
using TextBox = System.Windows.Forms.TextBox;

namespace YGN.Store.Management.UI.DetailForms
{
    public partial class ClientsForm : Form
    {
        #region members
        ClientManager manager = new ClientManager(new EfClientDal());
        private DataTable dataTable;
        private bool anyChangesMade = false;
        #endregion

        #region constructor
        public ClientsForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            getData();
            getNumberOfClientCount();
        }
        #endregion

        #region properties
        private string ClientName
        {
            get { return txtClientName.Text; }
            set
            {
                txtClientName.Text = value;
            }
        }
        private string ClientSurname
        {
            get { return txtClientSurname.Text; }
            set
            {
                txtClientSurname.Text = value;
            }
        }
        private string ClientFirmDescription
        {
            get { return txtClientFirmDescription.Text; }
            set
            {
                txtClientFirmDescription.Text = value;
            }
        }
        private string ClientPhoneNumber
        {
            get { return txtClientPhone.Text; }
            set
            {
                txtClientPhone.Text = value;
            }
        }
        private string ClientCode
        {
            get { return txtClientCode.Text; }
            set
            {
                txtClientCode.Text = value;
            }
        }
        private string ClientAddress
        {
            get { return txtAddress.Text; }
            set
            {
                txtAddress.Text = value;
            }
        }
        #endregion

        #region events
        private void btnAddClient_Click(object sender, EventArgs e)
        {
            var client = new Client
            {
                ClientName = ClientName,
                ClientSurname = ClientSurname,
                FirmDescription = ClientFirmDescription,
                TelNr1 = ClientPhoneNumber,
                ClientCode = ClientCode,
                Address = ClientAddress
            };
            ClientValidator itemValidator = new ClientValidator();
            ValidationResult result = itemValidator.Validate(client);
            if (result.IsValid)
            {
                bool isOk = manager.AddClient(client);
                getData();
                getNumberOfClientCount();
                if (isOk)
                {
                    MessageBox.Show("Cari Başarıyla Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Cari Eklenemedi. Aynı Cari Koda sahip bir cari zaten var ise tekrar kontrol ediniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Cari Kodu ve/veya Cari Adı Boş Bırakılamaz..", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            getData();
            getNumberOfClientCount();
        }
        private void clientsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtClientCode.Text = clientsDataGridView.CurrentRow.Cells[1].Value.ToString() ?? "";
            txtClientName.Text = clientsDataGridView.CurrentRow.Cells[2].Value.ToString() ?? "";
            txtClientSurname.Text = clientsDataGridView.CurrentRow.Cells[3].Value.ToString() ?? "";
            txtClientFirmDescription.Text = clientsDataGridView.CurrentRow.Cells[7].Value.ToString() ?? "";
            txtClientPhone.Text = clientsDataGridView.CurrentRow.Cells[5].Value.ToString() ?? "";
            txtAddress.Text = clientsDataGridView.CurrentRow.Cells[4].Value?.ToString() ?? "";
        }
        private void btnUpdateClient_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtClientCode.Text) || string.IsNullOrEmpty(txtClientName.Text))
            {
                MessageBox.Show("Güncellenecek Cari Seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    var getId = Convert.ToInt32(clientsDataGridView.CurrentRow.Cells[0].Value);
                    var client = new Client
                    {
                        Id = getId,
                        ClientName = ClientName,
                        ClientSurname = ClientSurname,
                        FirmDescription = ClientFirmDescription,
                        TelNr1 = ClientPhoneNumber,
                        ClientCode = ClientCode,
                        Address = ClientAddress
                    };
                    manager.UpdateClient(client);
                    MessageBox.Show("Güncelleme Başarılı !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    getData();
                    getNumberOfClientCount();
                }
                catch
                {
                    MessageBox.Show("Güncelleme yapılırken bir hata oluştu. Hüseyin Bey ile görüşünüz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private void btnDeleteClient_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtClientCode.Text) || string.IsNullOrEmpty(txtClientName.Text))
            {
                MessageBox.Show("Silinecek Cari Seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    var getId = Convert.ToInt32(clientsDataGridView.CurrentRow.Cells[0].Value);
                    string getClientCode = clientsDataGridView.CurrentRow.Cells[1].Value.ToString();
                    string getName = clientsDataGridView.CurrentRow.Cells[2].Value.ToString();
                    string getSurname = clientsDataGridView.CurrentRow.Cells[3].Value.ToString();
                    DialogResult dialogResult = MessageBox.Show(string.Format("{0} Kodlu, {1} {2} Adlı Kişiyi silmek istediğinize emin misiniz?", getClientCode, getName, getSurname), "Sil", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        var client = new Client
                        {
                            Id = getId,
                            ClientName = ClientName,
                            ClientSurname = ClientSurname,
                            FirmDescription = ClientFirmDescription,
                            TelNr1 = ClientPhoneNumber,
                            ClientCode = ClientCode
                        };
                        manager.DeleteClient(client);
                        MessageBox.Show("Silme Başarılı !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        getData();
                        getNumberOfClientCount();
                    }
                }
                catch
                {
                    MessageBox.Show("Silme işlemi yapılırken bir hata oluştu. Hüseyin ile görüşünüz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void txtSearchClient_TextChanged(object sender, EventArgs e)
        {
            string searchWord = txtSearchClient.Text.ToLower();
            DataView dv = new DataView(dataTable);
            dv.RowFilter = string.Format("[Cari Kodu] LIKE '%{0}%' OR CONVERT(Id, 'System.String') LIKE '%{0}%' OR [Cari Adı] LIKE '%{0}%' OR [Cari Soyad] LIKE '%{0}%' OR Adres LIKE '%{0}%' OR [Telefon - 1] LIKE '%{0}%' OR [Telefon - 2] LIKE '%{0}%' OR Firma LIKE '%{0}%' OR [Vergi Kimlik No] LIKE '%{0}%'", searchWord);
            clientsDataGridView.DataSource = dv;
        }
        private void ClientsForm_Load(object sender, EventArgs e)
        {
            LoadClients();
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

        #endregion

        #region private methods
        private void getData()
        {
            clientsDataGridView.DataSource = manager.GetClients();
        }
        private void getNumberOfClientCount()
        {
            lblCountOfClient.Text = clientsDataGridView.Rows.Count.ToString();
            lblCountOfClient.Visible = true;
        }
        private void LoadClients()
        {
            var clients = manager.GetClients();

            dataTable = new DataTable();
            dataTable.Columns.Add("Id", typeof(int));
            dataTable.Columns.Add("Cari Kodu", typeof(string));
            dataTable.Columns.Add("Cari Adı", typeof(string));
            dataTable.Columns.Add("Cari Soyad", typeof(string));
            dataTable.Columns.Add("Adres", typeof(string));
            dataTable.Columns.Add("Telefon - 1", typeof(string));
            dataTable.Columns.Add("Telefon - 2", typeof(string));
            dataTable.Columns.Add("Firma", typeof(string));
            dataTable.Columns.Add("Vergi Kimlik No", typeof(string));

            foreach (var client in clients)
            {
                dataTable.Rows.Add(client.Id, client.ClientCode, client.ClientName, client.ClientSurname, client.Address, client.TelNr1, client.TelNr2, client.FirmDescription, client.TaxIdentificationNumber);
            }

            clientsDataGridView.DataSource = dataTable;
        }

        #endregion

    }
}
