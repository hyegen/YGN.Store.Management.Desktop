﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YGN.Store.Management.Entities.Concrete;

namespace YGN.Store.Management.Business.Abstract
{
    public interface IUserService
    {
        void AddUser(User user);
        bool Login(string userName, string password);
        List<string> GetAllUsers();
    }
}
