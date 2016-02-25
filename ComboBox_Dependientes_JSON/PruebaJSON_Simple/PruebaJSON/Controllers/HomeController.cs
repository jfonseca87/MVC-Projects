﻿using PruebaJSON.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PruebaJSON.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public List<Continente> lstContinentes = new List<Continente>() 
        { 
            new Continente {Continente_Id = 1, NContinente = "Africa"},
            new Continente {Continente_Id = 2, NContinente = "America"},
            new Continente {Continente_Id = 3, NContinente = "Asia"},
            new Continente {Continente_Id = 4, NContinente = "Europa"},
            new Continente {Continente_Id = 5, NContinente = "Oceania"}
        };

        public List<Pais> lstPaises = new List<Pais>()
        {
            new Pais {Pais_Id = 1, NPais = "Colombia", Continente_Id = 2}, 
            new Pais {Pais_Id = 2, NPais = "Estados Unidos", Continente_Id = 2},
            new Pais {Pais_Id = 3, NPais = "Simbawe", Continente_Id = 1},
            new Pais {Pais_Id = 4, NPais = "Nigeria", Continente_Id = 1},
            new Pais {Pais_Id = 5, NPais = "Rusia", Continente_Id = 3},
            new Pais {Pais_Id = 6, NPais = "China", Continente_Id = 3},
            new Pais {Pais_Id = 7, NPais = "España", Continente_Id = 4}, 
            new Pais {Pais_Id = 1, NPais = "Alemania", Continente_Id = 4},
            new Pais {Pais_Id = 1, NPais = "Nueva Zelanda", Continente_Id = 5},
            new Pais {Pais_Id = 1, NPais = "Australia", Continente_Id = 5} 

        };


        public ActionResult Index()
        {
            //ViewBag.Continentes = lstContinentes;
            ViewData["dpContinente"] = new SelectList(lstContinentes, "Continente_Id", "NContinente");
            ViewData["dpPais"] = new SelectList(new [] {"Seleccione..."});
            return View();
        }

        public JsonResult getPaises(int id)
        {
            var paises = lstPaises.Where(x => x.Continente_Id == id);
            return Json(paises, JsonRequestBehavior.AllowGet);
        }

    }
}
