using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YGN.Store.Management.Core.Entities;

namespace YGN.Store.Management.Entities.Concrete
{
    public class ReportConfiguration : EntityTypeConfiguration<Report>
    {
        public ReportConfiguration()
        {
            Property(x => x.ReportName).HasMaxLength(100);
        }
    }
    public class Report : IEntity
    {
        [Key]
        public int Id { get; set; }
        public string ReportName { get; set; }
        public string ReportBinaryData { get; set; }
    }
}
