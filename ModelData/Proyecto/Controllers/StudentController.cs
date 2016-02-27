using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ModelData;

namespace Proyecto.Controllers
{
    public class StudentController : Controller
    {
        //
        // GET: /Student/

        private SchoolDBEntities ctx = new SchoolDBEntities();

        public ActionResult Index()
        {
            var query = from est in ctx.Students.AsEnumerable()
                        select new
                        {
                            Id = est.StudentID,
                            Nombre = est.StudentName
                        };

            var query1 = ctx.Students.Find(2);

            //Stored Procedure in EF
            var query2 = ctx.GetCoursesByStudentId(1).ToList<GetCoursesByStudentId_Result>();

            //IList<GetCoursesByStudentId_Result> consulta = new List<GetCoursesByStudentId_Result>();
            //foreach(var item in query2)
            //{
            //    consulta.Add(new GetCoursesByStudentId_Result { courseid = item.courseid, coursename = item.coursename, TeacherId = item.TeacherId });
            //}
                      
            return View("QueryStudent", query2);
        }

    }
}
