using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YGN.Store.Management.Entities.Views.MobViews
{
    public class MobItemSelectionViews
    {
        public int ItemId { get; set; }
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public int StockAmount { get; set; }
        public double UnitPrice { get; set; }
    }
}
