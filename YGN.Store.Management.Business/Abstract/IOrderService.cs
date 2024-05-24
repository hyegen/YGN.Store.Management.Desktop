using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YGN.Store.Management.Entities.Concrete;
using YGN.Store.Management.Entities.Views;
using YGN.Store.Management.Entities.Views.MobViews;

namespace YGN.Store.Management.Business.Abstract
{
    public interface IOrderService
    {
        List<LastTransactionsView> GetOrderLineViews();
        List<OrderDetailInformation> GetOrderDetailInformation(int orderId);
        List<OrderInformationTotalPrice> GetTotalPriceForOrderInformation(int orderId);
        List<OrderDetailClientForSlip> GetOrderDetailClientForSlip(int orderId);
        decimal GetTotalPriceForOrderInformationPrice(int orderId);
        MobItemSelectionViews MobGetProductByItemCode(string itemCode);
        List<SelectedItems> GetSelectedItemsInOrderTest(int orderId);
        Order GetOrderById(int orderId);
        void UpdateOrder(Order order);
        void DeleteOrderById(int orderId);
    }
}
