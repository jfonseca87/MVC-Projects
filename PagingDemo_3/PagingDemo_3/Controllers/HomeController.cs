using PagingDemo_3.Helpers;
using PagingDemo_3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PagingDemo_3.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public const int PageSize = 10;

        public ActionResult Index()
        {
            var people = new PagedData<Person>();

            using( var context = new PersonContext())
            {
                people.Data = context.Person.OrderBy(p => p.PersonId).Take(PageSize).ToList();
                people.NumberOfPages = Convert.ToInt32(Math.Ceiling((double)context.Person.Count() / PageSize));
                people.CurrentPage = 1;
            }
            return View(people);
        }

        public ActionResult PersonList(int id)
        {
            var people = new PagedData<Person>();

            using (var context = new PersonContext())
            {
                people.Data = context.Person.OrderBy(p => p.PersonId).Skip(PageSize * (id - 1)).Take(PageSize).ToList();
                people.NumberOfPages = Convert.ToInt32(Math.Ceiling((double)context.Person.Count() / PageSize));
                people.CurrentPage = id;
            }

            return PartialView(people);

        }

        public ActionResult InsertPeople()
        {
            ViewBag.Cabezote = "New Person";
            return View();
        }

        [HttpPost]
        public ActionResult InsertPeople(Person person)
        {
            if (ModelState.IsValid)
            {
                using (var context = new PersonContext())
                {
                    context.Person.Add(person);
                    context.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        public ActionResult EditPeople(int id)
        {
            ViewBag.Cabezote = "Edit Person";
            Person person = new Person();

            using (var context = new PersonContext())
            {
                person = context.Person.Find(id);
            }

            return View(person);
        }

        [HttpPost]
        public ActionResult EditPeople(Person person)
        {
            if(ModelState.IsValid)
            {
                using (var context = new PersonContext())
                {
                    context.Entry(person).State = System.Data.Entity.EntityState.Modified;
                    context.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        public ActionResult DeletePeople(int id)
        {
            ViewBag.Cabezote = "Delete Person";
            Person person = new Person();

            using (var context = new PersonContext())
            {
                person = context.Person.Find(id);
            }

            return View(person);
        }

        [HttpPost]
        public ActionResult DeletePeople(Person person)
        {
            using (var context = new PersonContext())
            {
                context.Entry(person).State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
            }

            return RedirectToAction("Index");
        }

    }
}
