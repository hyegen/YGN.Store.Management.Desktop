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

namespace YGN.Store.Management.UI.DetailForms
{
    public partial class InformationsForm : Form
    {
        OrderManager orderManager = new OrderManager(new EfOrderDal());
        public InformationsForm(int selectedID)
        {
            InitializeComponent();
            getDetailsFromDb(selectedID);
        }
        private void getDetailsFromDb(int selectedID)
        {
            informationDataGridView.DataSource = orderManager.GetOrderDetailInformation(selectedID);
            var totalPrice = orderManager.GetTotalPriceForOrderInformationPrice(selectedID).ToString();
            lblTotalPrice.Text = string.Format(totalPrice + " TL");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
