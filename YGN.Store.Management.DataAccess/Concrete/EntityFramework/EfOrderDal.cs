using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Data.SqlClient;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using YGN.Store.Management.Core.DataAccess.EntityFramework;
using YGN.Store.Management.Core.Entities;
using YGN.Store.Management.DataAccess.Abstract;
using YGN.Store.Management.DataAccess.Context;
using YGN.Store.Management.Entities.Concrete;
using YGN.Store.Management.Entities.Views;
using YGN.Store.Management.Entities.Views.MobViews;
using static System.Data.Entity.Infrastructure.Design.Executor;

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
        public Order GetOrderById(int orderId)
        {
            using (YGNContext context = new YGNContext())
            {
                //var result = (from o in context.Orders
                //                  where o.Id == orderId
                //                  select o).FirstOrDefault();
                //return result;
                // var a= context.Orders.Include(o => o.OrderLines)
                //         .FirstOrDefault(o => o.Id == orderId);
                var order = context.Orders.Include(o => o.OrderLines.Select(ol => ol.Item)).FirstOrDefault(o => o.Id == orderId);

                return order;
            }
        }
        public List<SelectedItems> GetSelectedItemsInOrderTest(int orderId)
        {
            using (YGNContext context = new YGNContext())
            {
                var orderViews = context.Database.SqlQuery<SelectedItems>("EXEC YGN_SELECTED_ITEMS_IN_ORDER_TEST {0}", orderId).ToList();
                return orderViews;
            }
        }
        public void UpdateOrder(Order order)
        {
            using (YGNContext context = new YGNContext())
            {
                // / İlişkili varlıkları Include veya Load metoduyla yükleyin
                // Örnek olarak: context.Entry(entity).Collection(e => e.RelatedEntities).Load();

                var existingEntity = context.Set<Order>().Find(order.Id);
                if (existingEntity != null)
                {
                    context.Entry(existingEntity).CurrentValues.SetValues(order);
                    context.SaveChanges();
                }
                else
                {
                    // Hata işlemleri veya ekleme işlemleri
                }
            }
        }
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