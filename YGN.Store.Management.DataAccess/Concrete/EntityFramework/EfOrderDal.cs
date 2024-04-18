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
    }
}
