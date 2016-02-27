using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Tercer_Dia_Lab2b.Models;

namespace MVC_Tercer_Dia_Lab2b.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult MuestraCustomer(Customer ObjCustomer)
        {
            if(ModelState.IsValid)
            {
                return View("MuestraCustomer", ObjCustomer);
            }
            else
            {
                return View("Index");
            }
        }

    }
}
