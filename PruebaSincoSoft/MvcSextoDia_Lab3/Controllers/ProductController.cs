using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcSextoDia_Lab3.Controllers
{
    public class ProductController : Controller
    {
        Product product = new Product();
        //
        // GET: /Product/

        public ActionResult Index()
        {
            return View(product.listarProduct());
        }

        [HttpPost]
        public ActionResult InsertProduct(Product product)
        {
            product.Code = Request.Form["txtCode"];
            product.Name = Request.Form["txtName"];
            product.Amount = Convert.ToDecimal(Request.Form["txtVal"]);
            product.Guardar();
            return RedirectToAction("Index");  
        }
    }
}
