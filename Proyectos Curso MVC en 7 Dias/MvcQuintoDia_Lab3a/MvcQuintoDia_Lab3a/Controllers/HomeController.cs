using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcQuintoDia_Lab3a.Controllers
{
    [HandleError]
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        
        public ActionResult Index()
        {
            int x = 0;
            x /= x;
            return View();
        }

    }
}
