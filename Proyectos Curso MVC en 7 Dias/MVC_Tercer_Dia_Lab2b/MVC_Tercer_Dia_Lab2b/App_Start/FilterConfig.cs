﻿using System.Web;
using System.Web.Mvc;

namespace MVC_Tercer_Dia_Lab2b
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}