using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YGN.Store.Management.Core.Entities;

namespace YGN.Store.Management.Entities.Concrete
{
    public class SendMailContent : IEntity
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "varbinary(max)")]
        public byte[] Content { get; set; }
        public DateTime CreatedDate { get; set; }
        public int ReportId { get; set; }
        public virtual Report Report { get; set; }

    }
}
