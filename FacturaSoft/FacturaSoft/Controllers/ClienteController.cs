using Model;
using FacturaSoft.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FacturaSoft.Controllers
{
    public class ClienteController : Controller
    {
        Cliente cliente = new Cliente();
        Registro registro = new Registro();
        private int pageSize = 10;
        //
        // GET: /Cliente/

        public ActionResult Index()
        {
            if( Session["Usuario"] != null)
            {
                var client = new PagedData<Cliente>();

                using(var context = new FacturaSoftContext())
                {
                    client.Data = context.Cliente.OrderBy(c => c.Id_Cliente).Take(pageSize).ToList();
                    client.NumberOfPages = Convert.ToInt32(Math.Ceiling((double)context.Cliente.Count() / pageSize));
                    client.CurrentPage = 1;
                }

                return View(client);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        //Controlador para la vista parcial
        public ActionResult ClienteList(int id)
        {
            var client = new PagedData<Cliente>();

            using (var context = new FacturaSoftContext())
            {
                client.Data = context.Cliente.OrderBy(c => c.Id_Cliente).Skip(pageSize * (id - 1)).Take(pageSize).ToList();
                client.NumberOfPages = Convert.ToInt32(Math.Ceiling((double)context.Cliente.Count() / pageSize));
                client.CurrentPage = id;
            }

            return PartialView(client);
        }

        public ActionResult NuevoCliente()
        {
            return View();
        }

        [HttpPost]
        public ActionResult NuevoCliente(Cliente client)
        {
            if( Session["Usuario"] != null )
            {
                if (ModelState.IsValid)
                {
                    client.GuardarCliente();
                    registro.Guardar(client.traeCliente(), "Cliente", "I", Convert.ToInt16(Session["Usuario"]));
                    return RedirectToAction("Index");
                }
                else
                {
                    return View();
                }
            }
            else 
            {
                return RedirectToAction("Index", "Home");
            }
        }

        public ActionResult EditaCliente(int id)
        {
            return View(cliente.traeCliente(id));
        }

        [HttpPost]
        public ActionResult EditaCliente(Cliente client)
        {
            if (Session["Usuario"] != null)
            {
                if (ModelState.IsValid)
                {
                    client.EditarCliente(client);
                    registro.Guardar(client.Id_Cliente, "Cliente", "U", Convert.ToInt16(Session["Usuario"]));
                    return RedirectToAction("Index");
                }
                else
                {
                    return View();
                }
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        public ActionResult EliminaCliente(int id)
        {
            return View(cliente.traeCliente(id));
        }

        public ActionResult EliminarCliente(Cliente client, int id)
        {
            if (Session["Usuario"] != null)
            {
                client.EliminarCliente(id);
                registro.Guardar(client.Id_Cliente, "Cliente", "D", Convert.ToInt16(Session["Usuario"]));
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }
    }
}
