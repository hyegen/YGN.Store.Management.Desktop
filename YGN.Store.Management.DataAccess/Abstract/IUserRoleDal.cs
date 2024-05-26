using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YGN.Store.Management.Entities.Concrete;

namespace YGN.Store.Management.DataAccess.Abstract
{
    public interface IUserRoleDal
    {
        List<UserRole> GetUserRoles(User _currentUser);
    }
}
