using ConvertirAJSON.Helpers;
using ConvertirAJSON.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace ConvertirAJSON.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View(getListado());
        }

        public ActionResult ConvertirJSON()
        {
            List<Persona> personas = getListado();
            ArchivoJSON archivo = new ArchivoJSON();
            archivo.creaArchivoJSON(personas);

            return RedirectToAction("Index");
        }

        public List<Persona> getListado()
        {
            List<Persona> lstPersonas = new List<Persona>() { 
                new Persona { ID = 1, Nombres = "Pedro Pablo", Apellidos = "Jaramillo León", Edad = 30, Mail = "pedro87@hotmail.com", Direccion = "Calle 5 # 15 - 84", Telefono = "8251425"},
                new Persona { ID = 2, Nombres = "Pedro Pablo", Apellidos = "Jaramillo León", Edad = 30, Mail = "pedro87@hotmail.com", Direccion = "Calle 5 # 15 - 84", Telefono = "8251425"},
                new Persona { ID = 3, Nombres = "Pedro Pablo", Apellidos = "Jaramillo León", Edad = 30, Mail = "pedro87@hotmail.com", Direccion = "Calle 5 # 15 - 84", Telefono = "8251425"},
                new Persona { ID = 4, Nombres = "Pedro Pablo", Apellidos = "Jaramillo León", Edad = 30, Mail = "pedro87@hotmail.com", Direccion = "Calle 5 # 15 - 84", Telefono = "8251425"},
                new Persona { ID = 5, Nombres = "Pedro Pablo", Apellidos = "Jaramillo León", Edad = 30, Mail = "pedro87@hotmail.com", Direccion = "Calle 5 # 15 - 84", Telefono = "8251425"},
                new Persona { ID = 6, Nombres = "Pedro Pablo", Apellidos = "Jaramillo León", Edad = 30, Mail = "pedro87@hotmail.com", Direccion = "Calle 5 # 15 - 84", Telefono = "8251425"},
                new Persona { ID = 7, Nombres = "Pedro Pablo", Apellidos = "Jaramillo León", Edad = 30, Mail = "pedro87@hotmail.com", Direccion = "Calle 5 # 15 - 84", Telefono = "8251425"},
                new Persona { ID = 8, Nombres = "Pedro Pablo", Apellidos = "Jaramillo León", Edad = 30, Mail = "pedro87@hotmail.com", Direccion = "Calle 5 # 15 - 84", Telefono = "8251425"},
                new Persona { ID = 9, Nombres = "Pedro Pablo", Apellidos = "Jaramillo León", Edad = 30, Mail = "pedro87@hotmail.com", Direccion = "Calle 5 # 15 - 84", Telefono = "8251425"},
                new Persona { ID = 10, Nombres = "Pedro Pablo", Apellidos = "Jaramillo León", Edad = 30, Mail = "pedro87@hotmail.com", Direccion = "Calle 5 # 15 - 84", Telefono = "8251425"}
            };

            return lstPersonas;
        }

    }
}
