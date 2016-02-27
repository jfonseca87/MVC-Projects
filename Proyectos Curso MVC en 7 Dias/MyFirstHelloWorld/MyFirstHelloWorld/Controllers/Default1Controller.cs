using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyFirstHelloWorld.Controllers
{
    public class Default1Controller : Controller
    {
        //
        // GET: /Default1/

        public ActionResult Index()
        {
            ViewData["CurrenTime"] = DateTime.Now.ToString();
            return View();
        }

    }
}
