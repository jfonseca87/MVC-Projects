using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Tercer_Dia_Lab2.Models;

namespace MVC_Tercer_Dia_Lab2.Controllers
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
        public ActionResult MuestraCustomer(Customer objCustomer)
        {
            if(ModelState.IsValid)
            {
                return View("MuestraCustomer", objCustomer);
            }
            else
            {
                return View("Index");
            }
        }
    }
}
