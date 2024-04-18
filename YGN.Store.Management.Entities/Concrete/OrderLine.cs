using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YGN.Store.Management.Core.Entities;

namespace YGN.Store.Management.Entities.Concrete
{

    public class OrderLine : IEntity
    {
        [Key]
        public int Id { get; set; }
        public int ItemId { get; set; }
        public Item Item { get; set; }
        public int Amount { get; set; }
        public DateTime DateTime { get; set; }
        public decimal LineTotal { get; set; }
        public int OrderId { get; set; }
        public virtual Order Order { get; set; }
        public int TransactionCode { get; set; }
    }
}
