using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using YGN.Store.Management.Core.Entities;

namespace YGN.Store.Management.Entities.Concrete
{
    public class UserConfiguration : EntityTypeConfiguration<User>
    {
        public UserConfiguration()
        {
            Property(u => u.BirthDate)
                .HasColumnType("date");
            Property(u => u.CreatedDate)
                .HasColumnType("date");
        }
    }
    public class User : IEntity
    {
        [Key]
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string NameSurname { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public DateTime? BirthDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string TelNr1 { get; set; }
        public string TelNr2 { get; set; }
    }

}
