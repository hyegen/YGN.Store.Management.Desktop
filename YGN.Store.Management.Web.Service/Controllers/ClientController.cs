using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using YGN.Store.Management.Business.Concrete;
using YGN.Store.Management.DataAccess.Concrete.EntityFramework;
using YGN.Store.Management.Entities.Concrete;
using YGN.Store.Management.Entities.Views;
using HttpGetAttribute = System.Web.Http.HttpGetAttribute;
using RouteAttribute = System.Web.Http.RouteAttribute;

namespace YGN.Store.Management.Web.Service.Controllers
{
    public class ClientController : ApiController
    {
        ClientManager clientManager = new ClientManager(new EfClientDal());

        [HttpGet]
        [Route("api/getAllClientsByCodeAndNameAndSurname")]
        public List<ClientCodeAndNameAndSurnameView> Index()
        {
            return clientManager.GetClientCodeAndNameAndSurname();
        }

        //DENEME
    }
}