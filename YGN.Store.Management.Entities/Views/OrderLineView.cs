using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YGN.Store.Management.Entities.Concrete;

namespace YGN.Store.Management.Entities.Views
{
    public class OrderLineView
    {
        public int Id { get; set; }
        public int ItemId { get; set; }
        public Item Item { get; set; }
        public int Amount { get; set; }
        public DateTime DateTime { get; set; }
        public decimal LineTotal { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }
    }
}
