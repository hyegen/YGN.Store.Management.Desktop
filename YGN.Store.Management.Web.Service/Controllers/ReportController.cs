using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using YGN.Store.Management.Business.Concrete;
using YGN.Store.Management.DataAccess.Concrete.EntityFramework;
using YGN.Store.Management.Entities.Views;
using HttpGetAttribute = System.Web.Mvc.HttpGetAttribute;
using RouteAttribute = System.Web.Http.RouteAttribute;

namespace YGN.Store.Management.Web.Service.Controllers
{
    public class ReportController : ApiController
    {
        ReportManager reportManager = new ReportManager(new EfReportDal());

        [Route("api/GetStockAmount")]
        [HttpGet]
        public List<StockAmountView> GetStockAmount()
        {
            return reportManager.GetStockAmountEachItem();
        }
    }
}