using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YGN.Store.Management.Business.Abstract;
using YGN.Store.Management.DataAccess.Abstract;
using YGN.Store.Management.Entities.Concrete;
using YGN.Store.Management.Entities.Views;

namespace YGN.Store.Management.Business.Concrete
{
    public class UserManager : IUserService
    {
        private readonly IUserDal _userDal;
        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }
        public bool Login(string userName, string password)
        {
            return _userDal.LoginByUsernameAndPassword(userName, password);
        }
        public List<string> GetAllUsers()
        {
            return _userDal.GetAllUsers();
        }
        public List<UserNameView> GetUserNameViews()
        {
            return _userDal.GetUserNameViews();
        }
        public User GetUser(string userName, string password)
        {
            var result = _userDal.GetUser(userName, password);
            if (result != null)
            {
                return result;
            }
            return null;
        }
    }
}
