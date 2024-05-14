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
                return context.Orders.Include(o => o.OrderLines).SingleOrDefault(o => o.Id == orderId);
            }
        }
        public List<SelectedItems> GetSelectedItemsInOrderTest(int orderId)
        {
            using (YGNContext context = new YGNContext())
            {
                //var orderViews = context.Database.SqlQuery<SelectedItems>("EXEC YGN_SELECTED_ITEMS_IN_ORDER_TEST {0}", orderId).ToList();
                //return orderViews;

                var result = (from ord in context.Orders
                              join orl in context.OrderLines on ord.Id equals orl.OrderId
                              join itm in context.Items on orl.ItemId equals itm.Id
                              where ord.Id == orderId
                              select new SelectedItems
                              {
                                  ItemId = itm.Id,
                                  ItemCode = itm.ItemCode,
                                  ItemName = itm.ItemName,
                                  Amount = orl.Amount,
                                  LineTotal = orl.LineTotal
                              }).ToList();

                return result;

            }
        }
        public void UpdateOrder(int orderId, List<OrderLine> updatedOrderLines)
        {
            using (YGNContext context = new YGNContext())
            {
                var order = GetOrderById(orderId);
                var existingOrderLines = order.OrderLines.ToList();

                UpdateRelatedEntities(existingOrderLines, updatedOrderLines);
                //UpdateOrderTotalPrice(orderId, updatedOrderLines);
                context.SaveChanges();
            }
        }
        public void UpdateOrderTotalPrice(int orderId, List<OrderLine> updatedOrderLines)
        {
            using (YGNContext context = new YGNContext())
            {
                var order = GetOrderById(orderId);
                decimal updatedTotalPrice = 0;
                //order.TotalPrice = updatedOrderLines.Select(x=>x.LineTotal).First();
                foreach (var item in updatedOrderLines.Select(x => x.LineTotal))
                {
                    updatedTotalPrice += item;
                }
                order.TotalPrice = updatedTotalPrice;
                Update(order);
                //var updatedTotalPrice = updatedOrderLines.Select(x => x.LineTotal).First();
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