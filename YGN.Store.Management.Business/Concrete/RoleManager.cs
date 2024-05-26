using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YGN.Store.Management.Business.Abstract;
using YGN.Store.Management.DataAccess.Abstract;
using YGN.Store.Management.Entities.Concrete;

namespace YGN.Store.Management.Business.Concrete
{
    public class RoleManager : IRoleService
    {
        private readonly IRoleDal _roleDal;

        public RoleManager(IRoleDal roleDal)
        {
            _roleDal = roleDal;
        }

        public List<Role> GetUserRoles(User _currentUser)
        {
            var result = _roleDal.GetUserRoles(_currentUser);
            if (result != null)
            {
                return result;
            }
            return null;
        }
    }
}
