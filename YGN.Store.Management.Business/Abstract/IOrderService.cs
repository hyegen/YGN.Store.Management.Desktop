using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YGN.Store.Management.Entities.Views;

namespace YGN.Store.Management.Business.Abstract
{
    public interface IOrderService
    {
        List<OrderLineView> GetOrderLineViews();
        List<OrderDetailInformation> GetOrderDetailInformation(int orderId);
        List<OrderInformationTotalPrice> GetTotalPriceForOrderInformation(int orderId);
        List<OrderDetailClientForSlip> GetOrderDetailClientForSlip(int orderId);
        decimal GetTotalPriceForOrderInformationPrice(int orderId);
    }
}
