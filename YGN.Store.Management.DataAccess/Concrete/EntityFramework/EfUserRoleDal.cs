using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YGN.Store.Management.Core.DataAccess.EntityFramework;
using YGN.Store.Management.DataAccess.Abstract;
using YGN.Store.Management.DataAccess.Context;
using YGN.Store.Management.Entities.Concrete;

namespace YGN.Store.Management.DataAccess.Concrete.EntityFramework
{
    public class EfUserRoleDal : EfGenericRepositoryBase<UserRole, YGNContext>, IUserRoleDal
    {
        public List<UserRole> GetUserRoles(User _currentUser)
        {
            using (var context = new YGNContext())
            {
                var roles = context.UserRoles
                    .Where(ur => ur.UserId == _currentUser.Id)
                   // .Select(ur => ur.Role)
                    .ToList();
                return roles;
            }
        }
    }
}
