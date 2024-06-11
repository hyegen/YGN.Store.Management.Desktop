using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using YGN.Store.Management.Business.Abstract;
using YGN.Store.Management.DataAccess.Context;
using YGN.Store.Management.Entities.Concrete;

namespace YGN.Store.Management.Business.Concrete
{
    public class AuthManager : IAuthService
    {
        private readonly YGNContext _dbContext;
        public AuthManager(YGNContext dbContext)
        {
            _dbContext = dbContext;
        }
        public User Login(string email, string password)
        {
            return new User { Email = email, Password = password };
        }

    }
}
