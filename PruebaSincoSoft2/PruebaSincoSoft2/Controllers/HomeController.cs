using PruebaSincoSoft2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PruebaSincoSoft2.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            ViewBag.Listado = getListado();
            return View();
        }

        [HttpPost]
        public ActionResult Guardar(Pedido pedido)
        {
            if (Request.Form["dpUsuario"] != "")
            {
                pedido.PedUsu = Convert.ToInt16(Request.Form["dpUsuario"]);
            }

            if(Request.Form["dpProducto"] != "")
            {
                pedido.PedProd = Request.Form["dpProducto"];
            }
            else
            {
                pedido.PedProd = null;
            }
            

            if(ModelState.IsValid)
            {
                using(var context = new SincoSoftContext())
                {
                    context.Entry(pedido).State = System.Data.Entity.EntityState.Added;
                    context.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.Listado = getListado();
                return View("Index");
            }
        }

        public JsonResult getValorUnitario(string id)
        {
            using(var context = new SincoSoftContext())
            {
                var valUnit = context.Producto.Where(p => p.ProID == id).ToList();
                return Json(valUnit, JsonRequestBehavior.AllowGet);
            }
        }

        public List<Pedido> getListado()
        {
            List<Pedido> lstPedido = new List<Pedido>();

            using (var context = new SincoSoftContext())
            {
                lstPedido = context.Pedido.ToList();
                ViewData["dpUsuario"] = new SelectList(context.Usuarios.ToList(), "UsuId", "UsuNombre");
                ViewData["dpProducto"] = new SelectList(context.Producto.ToList(), "ProID", "ProDesc");
            }

            return lstPedido;
        }
    }
}
