using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YGN.Store.Management.DataAccess.Context;
using YGN.Store.Management.Entities.Concrete;

namespace YGN.Store.Management.DataAccess.DbInit
{
    public class YGNDbInitializer : CreateDatabaseIfNotExists<YGNContext>
    {
        protected override void Seed(YGNContext context)
        {
            var roles = new List<Role>
            {
            new Role { RoleName = "Purchasing" },
            new Role { RoleName = "Sales" },
            new Role { RoleName = "Backup" }
            };

            roles.ForEach(r => context.Roles.Add(r));

            var users = new List<User>
            {
            new User { UserName = "Admin", Password = "1" },
            };

            users.ForEach(u => context.Users.Add(u));

            context.SaveChanges();

            var userRoles = new List<UserRole>
            {
            new UserRole { UserId = users[0].Id, RoleId = roles[0].Id },
            new UserRole { UserId = users[1].Id, RoleId = roles[1].Id },
            new UserRole { UserId = users[2].Id, RoleId = roles[2].Id }
            };

            userRoles.ForEach(ur => context.UserRoles.Add(ur));

            context.SaveChanges();
        }
    }
}
