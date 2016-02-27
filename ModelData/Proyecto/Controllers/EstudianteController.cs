using Proyecto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Proyecto.Controllers
{
    public class EstudianteController : Controller
    {
        //
        // GET: /Estudiante/
        int Edad = 0;
        
        IList<Estudiante> lstEstudiante = new List<Estudiante>() 
        {
            new Estudiante() { EstudianteId=1, EstudianteNombre="Pedro Flores", EstudianteEdad=18},
            new Estudiante() { EstudianteId=2, EstudianteNombre="Camila Alvarez", EstudianteEdad=15},
            new Estudiante() { EstudianteId=3, EstudianteNombre="Sandra Nova", EstudianteEdad=17},
            new Estudiante() { EstudianteId=4, EstudianteNombre="Julio Perdomo", EstudianteEdad=14},
            new Estudiante() { EstudianteId=5, EstudianteNombre="Juan Pasto", EstudianteEdad=17},
            new Estudiante() { EstudianteId=6, EstudianteNombre="Eduardo Benitez", EstudianteEdad=16},
            new Estudiante() { EstudianteId=7, EstudianteNombre="Camilo Puentes", EstudianteEdad=13},
            new Estudiante() { EstudianteId=8, EstudianteNombre="Rosana Mendieta", EstudianteEdad=16},
            new Estudiante() { EstudianteId=9, EstudianteNombre="Diego Martin", EstudianteEdad=15},
            new Estudiante() { EstudianteId=10, EstudianteNombre="Maria Rodrigo", EstudianteEdad=16}
        };
      
        public ActionResult Index()
        {
            
            //Utilizando el Query Sintax 
            Edad = 18;
            var filtroEstudiantes = from est in lstEstudiante
                                    where est.EstudianteEdad < Edad
                                    select est;
            //Utilizando el Method Sintax lambda expressions
            Edad = 17;
            var filtroEstudiantes2 = lstEstudiante.Where(s => s.EstudianteEdad < Edad).ToList<Estudiante>(); 
            //Utilizando Lambda Expressions with multiple parameters
            Edad = 18;
            var filtroEstudiantes3 = lstEstudiante.Where(s => s.EstudianteEdad == Edad && s.EstudianteNombre == "Pedro Flores");
            //OrderBy Ascending filtering expressions
            var filtroEstudiantes4 = from est in lstEstudiante
                                     orderby est.EstudianteEdad
                                     select est;
            //OrderBy Descending filtering expressions
            var filtroEstudiantes5 = lstEstudiante.OrderByDescending(s => s.EstudianteEdad).ToList<Estudiante>();
            //GroupBy Filtering Query Sintax
            var filtroEstudiantes6 = from est in lstEstudiante
                                     group est by est.EstudianteEdad;
            //Select with a some fields
            var filtroEstudiantes7 = from est in lstEstudiante
                                     select new { est.EstudianteNombre, est.EstudianteEdad };
            IList<SP_Datos_Estudiante> estFiltrado = new List<SP_Datos_Estudiante>();
            foreach (var estu in filtroEstudiantes7)
            {
                estFiltrado.Add(new SP_Datos_Estudiante { EstudianteNombre = estu.EstudianteNombre, EstudianteEdad = estu.EstudianteEdad });
            }

            //Mathematics expressions with linq it's not necessary create a view to see the result for the method application

            //Aggregate Method
            //It's only works with method sintax
            var filtroEstudiantes8 = lstEstudiante.Aggregate<Estudiante, string>("Student Names: ", (str, s) => str += s.EstudianteNombre + ", ");

            //Average Method
            //It's only works with method sintax
            var filtroEstudiantes9 = lstEstudiante.Average(s => s.EstudianteEdad);

            //Count Method 
            //It's works in query and method sintax
            //Query Sintax without overload
            var filtroEstudiantes10 = (from s in lstEstudiante
                                       select s.EstudianteEdad).Count();
            
            //Method Sintax without overload
            var filtroEstudiantes11 = lstEstudiante.Count();

            //Method sintax with overload
            var filtroEstudiantes12 = lstEstudiante.Count(s => s.EstudianteEdad <= 18);

            //Max Method
            //Query Sintax
            var filtroEstudiantes13 = (from s in lstEstudiante
                                       select s.EstudianteEdad).Max();
            //Method Sintax
            var filtroEstudiantes14 = lstEstudiante.Max(s => s.EstudianteNombre);

            //Sum Method
            //Method Sintax
            var filtroEstudiantes15 = lstEstudiante.Sum(s => s.EstudianteEdad);

            //ElementAt Method
            //Query Sintax
            var filtroEstudiantes16 = (from s in lstEstudiante
                                       select s).ElementAt(2);

            //Method Sintax
            var filtroEstudiantes17 = lstEstudiante.ElementAt(0);

            //ElementAtOrDefault Method
            //Query Sintax 
            var filtroEstudiantes18 = (from s in lstEstudiante
                                       select s).ElementAtOrDefault(3);

            //Method Sintax
            var filtroEstudiantes19 = lstEstudiante.ElementAtOrDefault(6);

            //First
            //Query Sintax 
            var filtroEstudiantes20 = (from s in lstEstudiante
                                       where s.EstudianteEdad > 11 && s.EstudianteEdad <= 15
                                       select s).First();

            //Method Sintax
            var filtroEstudiantes21 = lstEstudiante.First(s => s.EstudianteEdad < 15);

            //First Or Default
            //Query Sintax
            var filtroEstudiantes22 = (from s in lstEstudiante
                                       where s.EstudianteEdad > 11 && s.EstudianteEdad <= 15
                                       select s).FirstOrDefault();

            //Method Sintax
            var filtroEstudiantes23 = lstEstudiante.FirstOrDefault(s => s.EstudianteEdad > 15);


            return View("Query", filtroEstudiantes10);
        }

    }
}
