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
        public DateTime Date_ { get; set; }
        public string ItemName { get; set; }
        public string ClientName { get; set; }
        public string ClientSurname { get; set; }
        public string FirmDescription { get; set; }
        public decimal TotalPrice { get; set; }
        public string Module { get; set; }
    }
}
