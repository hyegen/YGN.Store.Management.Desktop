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

namespace YGN.Store.Management.DataAccess.Concrete.EntityFramework
{
    public class EfOrderDal : EfGenericRepositoryBase<Order, YGNContext>, IOrderDal
    {
        public List<LastTransactionsView> GetOrderLineViews()
        {
            using (var context = new YGNContext())
            {
                //var orderViews = context.Database.SqlQuery<LastTransactionsView>("EXEC YGN_LAST_TRANSACTIONS_VIEW").ToList();
                //return orderViews;
                var result = (from ord in context.Orders
                              join cl in context.Clients on ord.ClientId equals cl.Id
                              select new LastTransactionsView
                              {
                                  Id = ord.Id,
                                  ClientCode = cl.ClientCode,
                                  ClientName = cl.ClientName,
                                  ClientSurname = cl.ClientSurname,
                                  FirmDescription = cl.FirmDescription,
                                  Date_ = ord.DateTime,
                                  TotalPrice = ord.TotalPrice,
                                  //Module = ord.IOCode.ToString(),
                                  Module = (ord.IOCode == 1 ? "SATINALMA" :
                                            ord.IOCode == 2 ? "SATIŞ" : "BİLİNMİYOR"),
                                  PaymentType = (
                                                    ord.PaymentType == 1 ? "Kredi Kartı" :
                                                    ord.PaymentType == 2 ? "Nakit" :
                                                    ord.PaymentType == 3 ? "Vadeli" : "BİLİNMİYOR")
                              }).ToList();
                return result;
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
        public Order GetOrderById(int orderId)
        {
            using (YGNContext context = new YGNContext())
            {
                return context.Orders.Include(o => o.OrderLines).SingleOrDefault(o => o.Id == orderId);
            }
        }
        public List<SelectedItems> GetSelectedItemsInOrder(int orderId)
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
                                  OrderLineId = orl.Id,
                                  ItemId = itm.Id,
                                  ItemCode = itm.ItemCode,
                                  ItemName = itm.ItemName,
                                  Amount = orl.Amount,
                                  LineTotal = orl.LineTotal
                              }).ToList();

                return result;
            }
        }
        public void UpdateOrder(Order updatedOrder)
        {
            using (var context = new YGNContext())
            {
                var existingOrder = context.Orders.Include(o => o.OrderLines).SingleOrDefault(o => o.Id == updatedOrder.Id);

                if (existingOrder != null)
                {
                    existingOrder.DateTime = updatedOrder.DateTime;
                    existingOrder.TotalPrice = updatedOrder.TotalPrice;
                    existingOrder.IOCode = updatedOrder.IOCode;
                    existingOrder.ClientId = updatedOrder.ClientId;

                    foreach (var updatedOrderLine in updatedOrder.OrderLines)
                    {
                        //var existingOrderLine = existingOrder.OrderLines.SingleOrDefault(ol => ol.Id == updatedOrderLine.Id);
                        var existingOrderLine = existingOrder.OrderLines.SingleOrDefault(ol => ol.ItemId == updatedOrderLine.ItemId);
                        if (existingOrderLine != null)
                        {
                            existingOrderLine.ItemId = updatedOrderLine.ItemId;
                            existingOrderLine.Amount = updatedOrderLine.Amount;
                            existingOrderLine.DateTime = updatedOrderLine.DateTime;
                            existingOrderLine.LineTotal = updatedOrderLine.LineTotal;
                            existingOrderLine.IOCode = updatedOrderLine.IOCode;
                        }
                        else
                        {
                            existingOrder.OrderLines.Add(new OrderLine
                            {
                                ItemId = updatedOrderLine.ItemId,
                                Amount = updatedOrderLine.Amount,
                                DateTime = updatedOrderLine.DateTime,
                                LineTotal = updatedOrderLine.LineTotal,
                                IOCode = updatedOrderLine.IOCode,
                                OrderId = updatedOrder.Id
                            });
                        }
                    }

                    var orderLinesToDelete = existingOrder.OrderLines
                        .Where(ol => !updatedOrder.OrderLines.Any(uol => uol.Id == ol.Id)).ToList();

                    foreach (var orderLineToDelete in orderLinesToDelete)
                    {
                        context.OrderLines.Remove(orderLineToDelete);
                    }

                    context.SaveChanges();
                }
            }
        }
        public void DeleteOrderById(int orderId)
        {
            using (var context = new YGNContext())
            {
                var order = context.Orders.SingleOrDefault(o => o.Id == orderId);
                if (order != null)
                {
                    context.Orders.Remove(order);
                    context.SaveChanges();
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