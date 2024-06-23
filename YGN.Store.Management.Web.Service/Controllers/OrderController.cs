using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using YGN.Store.Management.Business.Concrete;
using YGN.Store.Management.DataAccess.Abstract;
using YGN.Store.Management.DataAccess.Concrete.EntityFramework;
using YGN.Store.Management.Entities.Concrete;
using YGN.Store.Management.Entities.Views.MobViews;

namespace YGN.Store.Management.Web.Service.Controllers
{
    public class OrderController : ApiController
    {
        OrderManager orderManager = new OrderManager(new EfOrderDal());

        [HttpPost]
        [Route("api/saveOrder")]
        public IHttpActionResult InsertOrders(Order order)
        {
            if (order != null)
            {
                orderManager.AddOrder(order);
                return Ok("Insertion is Successful.");
            }
            else
            {
                return BadRequest("Invalid order data.");
            }
        }

        [HttpGet]
        [Route("api/getProductByItemCode")]
        public MobItemSelectionViews MobGetProductByItemCode(string itemCode)
        {
            return orderManager.MobGetProductByItemCode(itemCode);
        }
    }
}
