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
using YGN.Store.Management.DataAccess.Concrete.EntityFramework;

namespace YGN.Store.Management.UI.CommonReports
{
    public partial class StockAmountForm : Form
    {
        ReportManager reportManager = new ReportManager(new EfReportDal());
        private DataTable dataTable;
        public StockAmountForm()
        {
            InitializeComponent();
            //getData();
        }

        private void getData()
        {
            stockAmountDataGridView.DataSource = reportManager.GetStockAmountEachItem();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchWord = txtSearch.Text.ToLower();
            DataView dv = new DataView(dataTable);
            dv.RowFilter = string.Format("[Malzeme Kodu] LIKE '%{0}%' OR [Malzeme Açıklaması] LIKE '%{0}%'", searchWord);
            stockAmountDataGridView.DataSource = dv;
        }

        private void StockAmountForm_Load(object sender, EventArgs e)
        {
            LoadStockAmount();
        }
        private void LoadStockAmount()
        {
            var results = reportManager.GetStockAmountEachItem();

            dataTable = new DataTable();
            dataTable.Columns.Add("Malzeme Kodu", typeof(string));
            dataTable.Columns.Add("Malzeme Açıklaması", typeof(string));
            dataTable.Columns.Add("Stok Miktarı", typeof(int));

            foreach (var result in results)
            {
                dataTable.Rows.Add(result.ItemCode, result.ItemName, result.StockAmount);
            }

            stockAmountDataGridView.DataSource = dataTable;
        }
    }
}
