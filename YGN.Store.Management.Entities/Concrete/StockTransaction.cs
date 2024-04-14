using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YGN.Store.Management.Core.Entities;

namespace YGN.Store.Management.Entities.Concrete
{
    public class StockTransaction : IEntity
    {
        [Key]
        public int Id { get; set; }
        public int ItemId { get; set; }
        public int? OrderId { get; set; }
        public int UserId { get; set; }
        public DateTime ProcessDate { get; set; }
        public int TrCode { get; set; }
    }
}
