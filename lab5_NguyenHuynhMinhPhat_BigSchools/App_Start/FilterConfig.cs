﻿using System.Web;
using System.Web.Mvc;

namespace lab5_NguyenHuynhMinhPhat_BigSchools
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
