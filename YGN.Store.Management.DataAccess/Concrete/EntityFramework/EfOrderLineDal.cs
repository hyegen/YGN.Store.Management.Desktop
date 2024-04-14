using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YGN.Store.Management.Core.DataAccess.EntityFramework;
using YGN.Store.Management.DataAccess.Abstract;
using YGN.Store.Management.DataAccess.Context;
using YGN.Store.Management.Entities.Concrete;

namespace YGN.Store.Management.DataAccess.Concrete.EntityFramework
{
    public class EfOrderLineDal : EfGenericRepositoryBase<OrderLine, YGNContext>, IOrderLineDal
    {
        public int getLastOrderId()
        {
            using (YGNContext context = new YGNContext())
            {
                var lastId = (from o in context.OrderLines
                              orderby o.Id descending
                              select o.Id).FirstOrDefault();

                //return lastId + 1;
                return lastId;
            }
        }
    }
}
