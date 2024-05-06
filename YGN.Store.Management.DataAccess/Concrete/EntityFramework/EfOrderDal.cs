using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YGN.Store.Management.Core.DataAccess.EntityFramework;
using YGN.Store.Management.DataAccess.Abstract;
using YGN.Store.Management.DataAccess.Context;
using YGN.Store.Management.Entities.Concrete;
using YGN.Store.Management.Entities.Views;
using YGN.Store.Management.Entities.Views.MobViews;

namespace YGN.Store.Management.DataAccess.Concrete.EntityFramework
{
    public class EfOrderDal : EfGenericRepositoryBase<Order, YGNContext>, IOrderDal
    {
        public List<OrderLineView> GetOrderLineViews()
        {
            using (YGNContext context = new YGNContext())
            {
                var orderViews = context.Database.SqlQuery<OrderLineView>("EXEC YGN_ORDERLINE_VIEW").ToList();
                return orderViews;
            }
        }
        public List<OrderDetailInformation> GetOrderDetailInformation(int orderId)
        {
            using (YGNContext context = new YGNContext())
            {
                var orderViews = context.Database.SqlQuery<OrderDetailInformation>("EXEC YGN_ORDER_INFORMATION_VIEW {0}", orderId).ToList();
                return orderViews;
            }
        }
        public List<OrderInformationTotalPrice> GetTotalPriceForOrderInformation(int orderId)
        {
            using (YGNContext context = new YGNContext())
            {
                var orderViews = context.Database.SqlQuery<OrderInformationTotalPrice>("EXEC YGN_ORDER_INFORMATION_TOTAL_PRICE_VIEW {0}", orderId).ToList();
                return orderViews;
            }
        }
        public decimal GetTotalPriceForOrderInformationPrice(int orderId)
        {
            using (YGNContext context = new YGNContext())
            {
                var orderViews = context.Database.SqlQuery<decimal>("EXEC YGN_ORDER_INFORMATION_TOTAL_PRICE_VIEW {0}", orderId).FirstOrDefault();
                return orderViews;
            }
        }
        public List<OrderDetailClientForSlip> GetOrderDetailClientForSlip(int orderId)
        {
            using (YGNContext context = new YGNContext())
            {
                var orderViews = context.Database.SqlQuery<OrderDetailClientForSlip>("EXEC YGN_ORDER_DETAIL_FOR_CLIENT_VIEW {0}", orderId).ToList();
                return orderViews;
            }
        }
        public MobItemSelectionViews MobGetProductByItemCode(string itemCode)
        {
            using (YGNContext context = new YGNContext())
            {
                var orderViews = context.Database.SqlQuery<MobItemSelectionViews>("EXEC YGN_MOB_ITEM_SELECTION_PARAMETERIZED {0}", itemCode).FirstOrDefault();
                return orderViews;
            }
        }
        public List<SelectedItemsInOrder> GetSelectedItemsInOrder(int orderId)
        {
            using (YGNContext context = new YGNContext())
            {
                var orderViews = context.Database.SqlQuery<SelectedItemsInOrder>("EXEC YGN_SELECTED_ITEMS_IN_ORDER {0}", orderId).ToList();
                return orderViews;
            }
        }
        //public IEnumerable<MobItemSelectionViews> ModGetProductByItemCode(string itemCode)
        //{
        //    using (YGNContext context = new YGNContext())
        //    {
        //        var orderViews = context.Database.SqlQuery<MobItemSelectionViews>("EXEC YGN_ORDER_DETAIL_FOR_CLIENT_VIEW {0}", itemCode).ToList();
        //        return orderViews;
        //    }
        //}
    }
}
