using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YGN.Store.Management.Business.Concrete;
using YGN.Store.Management.DataAccess.Concrete.EntityFramework;

namespace YGN.Store.Management.Web.Service.Controllers
{
    public class HomeController : Controller
    {
        UserManager userManager = new UserManager(new EfUserDal());
        public ActionResult Index()
        {
            try
            {
                var result = userManager.GetAllUsers();
                return View(result);
            }
            catch (Exception e)
            {
                return View(e.Message);
            }
        }
    }
}
