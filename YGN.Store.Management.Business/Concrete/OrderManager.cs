using System;
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
            if (order != null && order.OrderLines.Count() > 0)
            {
                _orderDal.Add(order);
            }
            else
            {
                return;
            }
        }
        public List<OrderDetailClientForSlip> GetOrderDetailClientForSlip(int orderId)
        {
            if (orderId != 0)
            {
                var result = _orderDal.GetOrderDetailClientForSlip(orderId);
                if (result != null && result.Count() > 0)
                {
                    return result;
                }
            }
            return null;
        }
        public List<OrderDetailInformation> GetOrderDetailInformation(int orderId)
        {
            if (orderId != 0)
            {
                var result = _orderDal.GetOrderDetailInformation(orderId);
                if (result != null && result.Count() > 0)
                {
                    return result;
                }
            }
            return null;
        }
        public List<LastTransactionsView> GetOrderLineViews()
        {
            var result = _orderDal.GetOrderLineViews();
            if (result != null && result.Count() > 0)
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        public List<OrderInformationTotalPrice> GetTotalPriceForOrderInformation(int orderId)
        {
            if (orderId != 0 && orderId > 0)
            {
                var result = _orderDal.GetTotalPriceForOrderInformation(orderId);
                if (result != null && result.Count() > 0)
                {
                    return result;
                }
            }
            return null;
        }
        public decimal GetTotalPriceForOrderInformationPrice(int orderId)
        {
            if (orderId != 0 && orderId > 0)
            {
                var result = _orderDal.GetTotalPriceForOrderInformationPrice(orderId);
                if (result != 0)
                {
                    return result;
                }
            }
            return 0;
        }
        public MobItemSelectionViews MobGetProductByItemCode(string itemCode)
        {
            if (string.IsNullOrEmpty(itemCode))
            {
                return null;
            }
            return _orderDal.MobGetProductByItemCode(itemCode);
        }
        public void DeleteOrder(Order order)
        {
            if (order != null)
            {
                _orderDal.Delete(order);
            }
        }
        public List<SelectedItems> GetSelectedItemsInOrderTest(int orderId)
        {
            if (orderId != 0 && orderId > 0)
            {
                var result = _orderDal.GetSelectedItemsInOrder(orderId);
                if (result != null && result.Count() > 0)
                {
                    return result;
                }
            }
            return null;
        }
        public Order GetOrderById(int orderId)
        {
            if (orderId != 0 && orderId > 0)
            {
                var result = _orderDal.GetOrderById(orderId);
                if (result != null)
                {
                    return result;
                }
            }
            return null;
        }
        public void UpdateOrder(Order order)
        {
            if (order != null)
            {
                _orderDal.UpdateOrder(order);
            }
            else
            {
                return;
            }
        }
        public void DeleteOrderById(int orderId)
        {
            if (orderId != 0 && orderId > 0)
            {
                _orderDal.DeleteOrderById(orderId);
            }
            else
            {
                return;
            }
        }
    }
}
