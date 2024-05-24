using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
        #region members
        OrderManager orderManager = new OrderManager(new EfOrderDal());
        #endregion

        #region constructor
        public InformationsForm(int selectedID)
        {
            InitializeComponent();
            getDetailsFromDb(selectedID);
        }
        #endregion

        #region events
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region private methods
        private void getDetailsFromDb(int selectedID)
        {
            var orderInformations = orderManager.GetOrderDetailInformation(selectedID);
            decimal totalPrice = 0;
            foreach (var total in orderInformations.Select(x => x.LineTotal))
            {
                totalPrice += total;
            }
            informationDataGridView.DataSource = orderInformations;
            string formattedTotalPrice = totalPrice.ToString("#,##0");
            lblTotalPrice.Text = formattedTotalPrice + " TL";
        }
        #endregion

    }
}
