﻿using System.Web;
using System.Web.Mvc;

namespace WEBSHOP_CKLT
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
