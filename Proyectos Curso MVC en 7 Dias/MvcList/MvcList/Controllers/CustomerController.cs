using MvcList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcList.Controllers
{
    public class CustomerController : Controller
    {
        //
        // GET: /Customer/

        List<Customer> lstCliente = new List<Customer>();


        public ActionResult Index()
        {
            if(ModelState.IsValid)
            {
                ViewBag.Mensaje = "Index";
                return View();
            }
            else
            {
                return View("NuevoCliente");
            }
            
        }

        public ActionResult NuevoCliente()
        {
            return View();
        }


    }
}
