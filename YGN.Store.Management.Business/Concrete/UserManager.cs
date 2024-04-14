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
    public class UserManager : IUserService
    {
        private readonly IUserDal _userDal;
        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public void AddUser(User user)
        {
            _userDal.Add(user);
        }

        public bool Login(string userName, string password)
        {
            return _userDal.LoginByUsernameAndPassword(userName, password);
        }

        public List<string> GetAllUsers()
        {
            return _userDal.GetAllUsers();
        }
    }
}
