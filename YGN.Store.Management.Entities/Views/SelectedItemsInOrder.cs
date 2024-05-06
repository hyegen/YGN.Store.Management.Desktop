using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YGN.Store.Management.Entities.Views
{
    public class SelectedItemsInOrder
    {
        public int OrderId { get; set; }
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public int Amount { get; set; }
        public double UnitPrice { get; set; }
        public decimal LineTotal{ get; set; }
    }
}
