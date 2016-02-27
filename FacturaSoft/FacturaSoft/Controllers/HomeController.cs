using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FacturaSoft.Controllers
{
    public class HomeController : Controller
    {
        static int perfil = 0;
        //
        // GET: /Home/

        public ActionResult Index()
        {
            Session["Operacion"] = "Log In";
            return View();
        }

        public ActionResult IndexVal()
        {
            if (Session["Usuario"] != null)
            {
                Pagina pagina = new Pagina();
                Session["lstPaginas"] = pagina.traePagina(perfil);
                Session["Operacion"] = "Log Out";
                return View();
            }
            else
            {
                return RedirectToAction("Index");
            }
        }

        public ActionResult Ingresar()
        {
            return View();
        }

        [HttpPost]
        public JsonResult ConsultaIngreso(Usuario usuario)
        {
            var consulta = usuario.ConsultaUsuario(usuario.Nick_Usuario, usuario.UPassword);
            if(consulta.Count != 0)
            {
                foreach(var item in consulta)
                {
                    Session["Usuario"] = item.Usuario_Id;
                    Session["Nombre"] = item.Nom_Usuario;
                    perfil = Convert.ToInt16(item.Id_Perfil);
                }
            }
            return Json(consulta, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Salir()
        {
            Session["Usuario"] = null;
            Session["Nombre"] = null;
            Session["lstPaginas"] = null;

            return RedirectToAction("Index");
        }
    }
}
