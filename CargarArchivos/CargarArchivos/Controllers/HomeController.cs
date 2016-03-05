using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;

namespace CargarArchivos.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Upload(string descripcion, HttpPostedFileBase fichero)
        {
            string ruta = Path.GetFileName(fichero.FileName);
            fichero.SaveAs(Path.Combine(@"D:\", Path.GetFileName(fichero.FileName)));
            return View();
        }

    }
}
