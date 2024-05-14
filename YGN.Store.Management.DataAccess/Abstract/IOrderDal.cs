using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YGN.Store.Management.Core.DataAccess;
using YGN.Store.Management.Entities.Concrete;
using YGN.Store.Management.Entities.Views;
using YGN.Store.Management.Entities.Views.MobViews;

namespace YGN.Store.Management.DataAccess.Abstract
{
    public interface IOrderDal : IEntityRepository<Order>
    {
        List<OrderLineView> GetOrderLineViews();
        List<OrderDetailInformation> GetOrderDetailInformation(int orderId);
        List<OrderInformationTotalPrice> GetTotalPriceForOrderInformation(int orderId);
        List<OrderDetailClientForSlip> GetOrderDetailClientForSlip(int orderId);
        decimal GetTotalPriceForOrderInformationPrice(int orderId);
        MobItemSelectionViews MobGetProductByItemCode(string itemCode);
        List<SelectedItemsInOrder> GetSelectedItemsInOrder(int orderId);
        List<SelectedItems> GetSelectedItemsInOrderTest(int orderId);
        Order GetOrderById(int orderId);
        void UpdateOrder(int id, List<OrderLine> updatedOrderLines);
    }
}
