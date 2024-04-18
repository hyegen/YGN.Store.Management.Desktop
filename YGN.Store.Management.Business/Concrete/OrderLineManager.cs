using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YGN.Store.Management.Business.Abstract;
using YGN.Store.Management.DataAccess.Abstract;
using YGN.Store.Management.Entities.Concrete;

namespace YGN.Store.Management.Business.Concrete
{
    public class OrderLineManager : IOrderLineService
    {
        private readonly IOrderLineDal _orderLineDal;

        public OrderLineManager(IOrderLineDal orderLineDal)
        {
            _orderLineDal = orderLineDal;
        }

        public int getLastOrderId()
        {
            return _orderLineDal.getLastOrderId();
        }
        public void AddOrderLine(OrderLine orderLine)
        {
            _orderLineDal.Add(orderLine);
        }
    }
}
