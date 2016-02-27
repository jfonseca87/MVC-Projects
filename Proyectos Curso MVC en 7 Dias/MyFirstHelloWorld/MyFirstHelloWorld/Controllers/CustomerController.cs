using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyFirstHelloWorld.Models;

namespace MyFirstHelloWorld.Controllers
{
    public class CustomerController : Controller
    {
        //
        // GET: /Customer/

       public ActionResult DisplayCustomer()
       {
           Customer objCustomer = new Customer();
           objCustomer.Code = Request.Form["customercod"].ToString();
           objCustomer.Name = Request.Form["customername"].ToString();
           objCustomer.Amount = Convert.ToInt16(Request.Form["customeramount"].ToString());

           return View("DisplayCustomer", objCustomer);
       }

       public ActionResult FillCustomer()
       {
           return View();
       }

    }
}
