using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcSextoDia_Lab3.Controllers
{
    public class CustomerController : Controller
    {
        Customer cliente = new Customer();
        //
        // GET: /Customer/

        public ActionResult Index()
        {
            return View(cliente.listarCustomer());
        }

        [HttpPost]
        public ActionResult InsertCustomer(Customer customer)
        {
            cliente.Code = Request.Form["txtCode"];
            cliente.Name = Request.Form["txtName"];
            cliente.Amount = Convert.ToDecimal(Request.Form["txtAmount"]);
            cliente.Guardar();
            return RedirectToAction("Index");
        }
    }
}
