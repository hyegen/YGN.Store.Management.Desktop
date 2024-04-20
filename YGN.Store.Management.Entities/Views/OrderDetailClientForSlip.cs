using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YGN.Store.Management.Entities.Views
{
    public class OrderDetailClientForSlip
    {
        public int OrderId { get; set; }
        public string ClientCode { get; set; }
        public string ClientName { get; set; }
        public string ClientSurname { get; set; }
        public string FirmDescription { get; set; }
    }
}
