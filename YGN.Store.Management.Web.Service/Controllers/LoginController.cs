using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using YGN.Store.Management.Business.Concrete;
using YGN.Store.Management.DataAccess.Concrete.EntityFramework;
using YGN.Store.Management.Entities.Views;
using HttpGetAttribute = System.Web.Http.HttpGetAttribute;
using HttpPostAttribute = System.Web.Mvc.HttpPostAttribute;
using RouteAttribute = System.Web.Http.RouteAttribute;


namespace YGN.Store.Management.Web.Service.Controllers
{
    public class LoginController : ApiController
    {
        UserManager userManager = new UserManager(new EfUserDal());

        [HttpPost]
        [Route("api/login")]
        public IHttpActionResult LoginUserNameAndPassword(string userName, string password)
        {
            bool isAuthenticated = userManager.Login(userName, password);

            if (isAuthenticated)
            {
                return Ok("Giriş Başarılı");
            }
            else
            {
                return BadRequest("Giriş Başarısız");
            }
        }

        [HttpGet]
        [Route("api/getAllUsers")]
        public List<UserNameView> GetAllUsers()
        {
            return userManager.GetUserNameViews();
        }
    }
}