using System;
using System.Collections.Generic;
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
    public class EfReportDal : EfGenericRepositoryBase<OrderLine, YGNContext>, IReportDal
    {
        public List<StockAmountView> GetStockAmountEachItem()
        {
            using (YGNContext context = new YGNContext())
            {
                var result = context.Database.SqlQuery<StockAmountView>("EXEC YGN_STOCK_AMOUNT_VIEW").ToList();
                return result;
            }
        }
    }
}
