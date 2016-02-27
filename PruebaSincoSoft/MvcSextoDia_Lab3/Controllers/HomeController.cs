using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcSextoDia_Lab3.Controllers
{
    public class HomeController : Controller
    {
        Bill factura = new Bill();
        Customer customer = new Customer();
        Product product = new Product();
        //
        // GET: /Home/

        public ActionResult Index()
        {
            ViewData["dpCustomer"] = new SelectList(customer.listarCustomer(), "Code", "Name");
            ViewData["dpProduct"] = new SelectList(product.listarProduct(), "Code", "Name");
            return View(factura.listarFactura());
        }

        [HttpPost]
        public ActionResult InsertFactura(Bill factura)
        {
            factura.codCustomer = Request.Form["dpCustomer"];
            factura.codProduct = Request.Form["dpProduct"];
            factura.valUnit = Convert.ToDecimal(Request.Form["txtValUnit"]);
            factura.cantProduct = Convert.ToInt16(Request.Form["txtCantidad"]);
            factura.subtotal = Convert.ToDecimal(Request.Form["txtSubtotal"]);
            factura.IVA = Convert.ToDecimal(Request.Form["txtIVA"]);
            factura.total = Convert.ToDecimal(Request.Form["txtTotal"]);
            factura.Guardar();
            return RedirectToAction("Index");
        }

        public JsonResult getValorUnitario(string id)
        {
            var valor = product.ConsultaValor(id);
            return Json(valor, JsonRequestBehavior.AllowGet);
        }
    }
}
