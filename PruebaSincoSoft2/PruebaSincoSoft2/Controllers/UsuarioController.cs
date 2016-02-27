using PruebaSincoSoft2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PruebaSincoSoft2.Controllers
{
    public class UsuarioController : Controller
    {
        //
        // GET: /Usuario/

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Guardar(Usuarios usuario)
        {
            if (ModelState.IsValid)
            {
                using(var context = new SincoSoftContext())
                {
                    context.Entry(usuario).State = System.Data.Entity.EntityState.Added;
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
