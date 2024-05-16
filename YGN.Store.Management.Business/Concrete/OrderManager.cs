﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using YGN.Store.Management.Business.Abstract;
using YGN.Store.Management.DataAccess.Abstract;
using YGN.Store.Management.Entities.Concrete;
using YGN.Store.Management.Entities.Views;
using YGN.Store.Management.Entities.Views.MobViews;

namespace YGN.Store.Management.Business.Concrete
{
    public class OrderManager : IOrderService
    {
        private readonly IOrderDal _orderDal;
        public OrderManager(IOrderDal orderDal)
        {
            _orderDal = orderDal;
        }
        public void AddOrder(Order order)
        {
            _orderDal.Add(order);
        }
        public List<OrderDetailClientForSlip> GetOrderDetailClientForSlip(int orderId)
        {
            return _orderDal.GetOrderDetailClientForSlip(orderId);
        }
        public List<OrderDetailInformation> GetOrderDetailInformation(int orderId)
        {
            return _orderDal.GetOrderDetailInformation(orderId);
        }
        public List<OrderLineView> GetOrderLineViews()
        {
            return _orderDal.GetOrderLineViews();
        }
        public List<OrderInformationTotalPrice> GetTotalPriceForOrderInformation(int orderId)
        {
            return _orderDal.GetTotalPriceForOrderInformation(orderId);
        }
        public decimal GetTotalPriceForOrderInformationPrice(int orderId)
        {
            return _orderDal.GetTotalPriceForOrderInformationPrice(orderId);
        }
        public MobItemSelectionViews MobGetProductByItemCode(string itemCode)
        {
            return _orderDal.MobGetProductByItemCode(itemCode);
        }
        public void DeleteOrder(Order order)
        {
            _orderDal.Delete(order);
        }
        public List<SelectedItems> GetSelectedItemsInOrderTest(int orderId)
        {
            return _orderDal.GetSelectedItemsInOrder(orderId);
        }
        public Order GetOrderById(int orderId)
        {
            return _orderDal.GetOrderById(orderId);
        }
        public void UpdateOrder(Order order)
        {
            _orderDal.UpdateOrder(order);
        }
        public void DeleteOrderById(int orderId)
        {
            _orderDal.DeleteOrderById(orderId);
        }
    }
}
