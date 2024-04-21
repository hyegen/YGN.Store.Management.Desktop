using Microsoft.Reporting.WinForms;
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

namespace YGN.Store.Management.UI.Report
{
    public partial class PrintOrderSlip : Form
    {
        OrderManager orderManager = new OrderManager(new EfOrderDal());
        public PrintOrderSlip()
        {
            InitializeComponent();
        }

        private void PrintOrderSlip_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
        }

        private void btnPrintOrderDetail_Click(object sender, EventArgs e)
        {
            startOrderInformation();
        }

        private void PrintOrderSlip_Shown(object sender, EventArgs e)
        {
            txtOrderId.Focus();
        }

        private void txtOrderId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                startOrderInformation();
            }
        }
        private void startOrderInformation()
        {
            if (string.IsNullOrEmpty(txtOrderId.Text))
            {
                MessageBox.Show("Lütfen Id Giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int orderId = Convert.ToInt32(txtOrderId.Text);
                var reportResult = orderManager.GetOrderDetailInformation(orderId);
                var clientResult = orderManager.GetOrderDetailClientForSlip(orderId);
                var lastPriceResult = orderManager.GetTotalPriceForOrderInformation(orderId);

                ReportDataSource dataSourceReport = new ReportDataSource("DataSet_Report", reportResult);
                ReportDataSource dataSourceGetClient = new ReportDataSource("DataSet_GetClient", clientResult);
                ReportDataSource dataSourceGetLastPrice = new ReportDataSource("DataSetGetOrderLastPrice", lastPriceResult);

                this.reportViewer1.LocalReport.DataSources.Clear();

                this.reportViewer1.LocalReport.DataSources.Add(dataSourceReport);
                this.reportViewer1.LocalReport.DataSources.Add(dataSourceGetClient);
                this.reportViewer1.LocalReport.DataSources.Add(dataSourceGetLastPrice);

                this.reportViewer1.RefreshReport();
            }
        }
    }
}
