using MvcPerson.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcPerson.Controllers
{
    public class PersonController : Controller
    {
        static List<Person> people = new List<Person>();
        //
        // GET: /Person/

        public ActionResult Index()
        {
            return View(people);
        }

        //
        // GET: /Person/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Person/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Person/Create

        [HttpPost]
        public ActionResult Create(Person p)
        {
            if (!ModelState.IsValid)
            {
                return View("Create", p);
            }

            people.Add(p);

            return RedirectToAction("Index");
        }

        //
        // GET: /Person/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }
        //
        // POST: /Person/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Person/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Person/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
