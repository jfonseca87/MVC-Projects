using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcQuintoDia_Lab3.Controllers
{
    public class TesteandoController : Controller
    {
       public ActionResult TesteandoMetodo()
       {
           int x = 0;
           x /= x;
           return View();
       }

       protected override void OnException(ExceptionContext filterContext)
       {
           Exception e = filterContext.Exception;
           filterContext.Result = new ViewResult
           {
               ViewName = "Error"
           };
           filterContext.ExceptionHandled = true;
       }

    }
}
