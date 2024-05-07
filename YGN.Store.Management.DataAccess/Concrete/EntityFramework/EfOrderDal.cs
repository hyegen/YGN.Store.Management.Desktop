using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Data.SqlClient;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YGN.Store.Management.Core.DataAccess.EntityFramework;
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
        //public IEnumerable<MobItemSelectionViews> ModGetProductByItemCode(string itemCode)
        //{
        //    using (YGNContext context = new YGNContext())
        //    {
        //        var orderViews = context.Database.SqlQuery<MobItemSelectionViews>("EXEC YGN_ORDER_DETAIL_FOR_CLIENT_VIEW {0}", itemCode).ToList();
        //        return orderViews;
        //    }
        //}

        //public void UpdateOrder(Order order)
        //{
        //    using (YGNContext context = new YGNContext())
        //    {
        //        // İlişkili OrderLine'ları güncelleyin
        //        foreach (var orderLine in order.OrderLines)
        //        {
        //            context.OrderLines.Attach(orderLine);
        //            var entry = context.Entry(orderLine);
        //            entry.State = EntityState.Modified;
        //        }

        //        // Order'ı güncelleyin
        //        context.Orders.Attach(order);
        //        var orderEntry = context.Entry(order);
        //        orderEntry.State = EntityState.Modified;

        //        // Değişiklikleri kaydedin
        //        context.SaveChanges();
        //    }
        //}

        public void UpdateOrder(Order order)
        {
            using (YGNContext context = new YGNContext())
            {
                // Order nesnesini bağlama ekle veya güncelle
                if (order.Id != 0)
                {
                    context.Orders.Attach(order);
                    context.Entry(order).State = EntityState.Modified;
                }
                else
                {
                    context.Orders.Add(order);
                }

                // OrderLine nesnelerini bağlama ekle veya güncelle
                foreach (var orderLine in order.OrderLines)
                {
                    if (orderLine.Id != 0)
                    {
                        context.OrderLines.Attach(orderLine);
                        context.Entry(orderLine).State = EntityState.Modified;
                    }
                    else
                    {
                        context.OrderLines.Add(orderLine);
                    }
                }

                // Değişiklikleri kaydet
                context.SaveChanges();
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
    }
}
