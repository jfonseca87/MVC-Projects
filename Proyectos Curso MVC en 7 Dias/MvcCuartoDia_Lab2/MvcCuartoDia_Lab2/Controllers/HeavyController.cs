using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Threading;
using System.Threading.Tasks;

namespace MvcCuartoDia_Lab2.Controllers
{
    public class HeavyController : AsyncController
    {
        //
        // GET: /Heavy/

        public void AlgunMetodoHeavyAsync()
        {
            AsyncManager.OutstandingOperations.Increment();
            Task.Run(new Action(Heavy));
        }

        public void Heavy()
        {
            Thread.Sleep(20000);
            AsyncManager.OutstandingOperations.Decrement();
        }

        public ActionResult AlgunMetodoHeavyCompleted()
        {
            return View();
        }

    }
}
