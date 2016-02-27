using RoutesCustomer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RoutesCustomer.Controllers
{
    public class CustomerController : Controller
    {
        List<Customer> Customers = new List<Customer>();
        //
        // GET: /Customer/

        public CustomerController() 
        {
            Customer obj1Customer = new Customer();
            obj1Customer.Code = "11";
            obj1Customer.Name = "Pedro Franco";
            obj1Customer.Amount = 30;
            Customers.Add(obj1Customer);

            Customer obj2Customer = new Customer();
            obj2Customer.Code = "12";
            obj2Customer.Name = "Casimiro Rojas";
            obj2Customer.Amount = 26;
            Customers.Add(obj2Customer);
        }

        [HttpGet]
        public ViewResult DisplayCustomer(int id)
        {
            Customer objCustomer = Customers[id];
            return View("DisplayCustomer", objCustomer);
        }

    }
}
