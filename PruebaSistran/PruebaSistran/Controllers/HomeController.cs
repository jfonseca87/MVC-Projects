
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PruebaSistran.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        ClienteView clienteVista = new ClienteView();
        Cliente cliente = new Cliente();
        Sede sede = new Sede();
        ClienteCiudad clienteCiudad = new ClienteCiudad();
        TOP5Clientes topClientes = new TOP5Clientes();

        public ActionResult Index()
        {
            return View(clienteVista.ListarCliente());
        }

        public ActionResult nuevoCliente(int id = 0)
        {
            ViewBag.Sedes = sede.ListarSedes();
            return View(
                id > 0 ? cliente.ObtenerCliente(id) : cliente
            );
        }

        [HttpPost]
        public ActionResult nuevoCliente(Cliente cliente)
        {
            if (cliente.IdCliente == 0)
            {
                cliente.FechaRegistro = System.DateTime.Now;
            }
            
            if (ModelState.IsValid == true)
            {
                try
                {
                    cliente.CUCliente(cliente.IdCliente);
                    return RedirectToAction("Index");
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
            else 
            {
                ViewBag.Sedes = sede.ListarSedes();
                return View( cliente );
            }
        }

        public ActionResult eliminaCliente(int id)
        {
            return View(cliente.ObtenerCliente(id));
        }

        [HttpPost]
        public ActionResult eliminaCliente(Cliente cliente)
        {
            try
            {
                cliente.borraCliente(cliente.IdCliente);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public JsonResult QueryClienteCiudad()
        {
            return Json(clienteCiudad.listarClienteCiudad(), JsonRequestBehavior.AllowGet);
        }

        public JsonResult QueryTopClientes()
        {
            return Json(topClientes.listarTop5Clientes(), JsonRequestBehavior.AllowGet);
        }
    }
}
