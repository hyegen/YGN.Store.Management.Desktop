using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using YGN.Store.Management.Business.Abstract;
using YGN.Store.Management.DataAccess.Abstract;
using YGN.Store.Management.Entities.Concrete;

namespace YGN.Store.Management.Business.Concrete
{
    public class UserRoleManager : IUserRoleService
    {
        private readonly IUserRoleDal _userRoleDal;

        public UserRoleManager(IUserRoleDal userRoleDal)
        {
            _userRoleDal = userRoleDal;
        }

        public List<UserRole> GetUserRoles(User _currentUser)
        {
            if (_currentUser == null)
            {
                return null;
            }
            var result = _userRoleDal.GetUserRoles(_currentUser);
            if (result == null)
            {
                return null;
            }
            else
            {
                return result;
            }
        }
    }
}
