using PruebaSincoSoft2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PruebaSincoSoft2.Controllers
{
    public class ProductoController : Controller
    {
        //
        // GET: /Producto/

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Guardar(Producto producto)
        {
            if (ModelState.IsValid)
            {
                using(var context = new SincoSoftContext())
                {
                    context.Entry(producto).State = System.Data.Entity.EntityState.Added;
                    context.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            else
            {
                return View("Index");
            }
        }

    }
}
