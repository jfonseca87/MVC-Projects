using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        private Alumno alumno = new Alumno();
        private Curso curso = new Curso();

        public ActionResult Index()
        {
            return View(alumno.Listar());
        }

        public ActionResult Details(int id)
        {
            return View(alumno.Obtener(id));
        }

        public ActionResult Crud(int id = 0)
        {
            ViewBag.Cursos = curso.Todo();

            return View(
                id > 0 ? alumno.Obtener(id)
                       : alumno
                );
        }


        [HttpPost]
        public ActionResult Guardar(Alumno model, int[] CursosAc = null)
        {
            if(CursosAc != null)
            {
                foreach( var c in CursosAc)
                {
                    model.Cursos.Add(new Curso { Id_Curso = c });
                }
            }
            else 
            {
                ModelState.AddModelError("Cursos", "Debe seleccionar almenos una asignatura");
            }
           
            if (ModelState.IsValid)
            {
                model.Guardar();
                return Redirect("Index");
            }else
            {
                ViewBag.Cursos = curso.Todo();
                return View("Crud", model);
            }  
        }

        public ActionResult Eliminar(int id)
        {
            alumno.Eliminar(id);
            return Redirect("~/home/index");
        }

        //[HttpPost]
        //public ActionResult Adjuntar(Alumno model, HttpPostedFileBase file)
        //{

        //    if (file != null)
        //    {
        //        string adjunto = DateTime.Now.ToString("yyyyMMHHmmss") + Path.GetExtension(file.FileName);
        //        file.SaveAs(Server.MapPath("~/Uploads/" + adjunto));

        //        //alumno.SubirArchivo(new Adjunto
        //        //{
        //        //    Archivo = adjunto,
        //        //    Id_Alumno = alumnoId
        //        //});
        //    }
        //    else
        //    {
        //        ModelState.AddModelError("File", "Debe adjuntar un archivo");
        //    }

            
        //}
    }
}
