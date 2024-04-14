using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YGN.Store.Management.Core.Entities;

namespace YGN.Store.Management.Entities.Concrete
{
    public class Order : IEntity
    {
        [Key]
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public decimal TotalPrice { get; set; }
        public ICollection<OrderLine> OrderLines { get; set; }
    }
}
