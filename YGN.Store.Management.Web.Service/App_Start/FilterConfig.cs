﻿using System.Web;
using System.Web.Mvc;

namespace YGN.Store.Management.Web.Service
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
