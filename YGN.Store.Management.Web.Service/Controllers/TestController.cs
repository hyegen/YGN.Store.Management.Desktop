using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YGN.Store.Management.Business.Concrete;
using YGN.Store.Management.DataAccess.Concrete.EntityFramework;
using YGN.Store.Management.Entities.Views;

namespace YGN.Store.Management.Web.Service.Controllers
{
    public class TestController : Controller
    {
        ReportManager reportManager = new ReportManager(new EfReportDal());

        [HttpGet]
        public ActionResult GetStockAmounts()
        {
            var a = reportManager.GetStockAmountEachItem();
            return View(a);
        }
    }
}