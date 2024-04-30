using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YGN.Store.Management.Core.DataAccess.EntityFramework;
using YGN.Store.Management.DataAccess.Abstract;
using YGN.Store.Management.DataAccess.Context;
using YGN.Store.Management.Entities.Concrete;
using YGN.Store.Management.Entities.Views;

namespace YGN.Store.Management.DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfGenericRepositoryBase<User, YGNContext>, IUserDal
    {
        public bool LoginByUsernameAndPassword(string userName, string password)
        {
            using (YGNContext context = new YGNContext())
            {
                var result =
                    from i in context.Users
                    where i.UserName == userName && i.Password == password
                    select i;

                return result.Any();
            }
        }

        public List<string> GetAllUsers()
        {
            using (YGNContext context = new YGNContext())
            {
                var result =
                    (from u in context.Users
                     select u.UserName).ToList();
                return result;
            }
        }
        public List<UserNameView> GetUserNameViews()
        {
            using (YGNContext context = new YGNContext())
            {
                var result =
                    (from u in context.Users
                     select u.UserName).ToList().Select(x => new UserNameView { UserName = x }).ToList();
                return result;
            }
        }
    }

}
