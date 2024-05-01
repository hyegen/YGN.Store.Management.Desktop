using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using YGN.Store.Management.Business.Concrete;
using YGN.Store.Management.DataAccess.Concrete.EntityFramework;
using YGN.Store.Management.Entities.Views.MobViews;

namespace YGN.Store.Management.Web.Service.Controllers
{
    public class ItemController : ApiController
    {
        ItemManager itemManager = new ItemManager(new EfItemDal());

        [HttpGet]
        [Route("api/mobGetItemSelectionViews")]
        public List<MobItemSelectionViews> GetMobItemSelectionViews()
        {
            return itemManager.MobGetItemsView();
        }
    }
}
