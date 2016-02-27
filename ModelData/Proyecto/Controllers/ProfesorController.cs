using Proyecto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Proyecto.Controllers
{
    public class ProfesorController : Controller
    {
        //
        // GET: /Profesor/

        IList<Materia> lstMateria = new List<Materia>()
        {
            new Materia { MateriaId=1, MateriaNombre="Bases de Datos"},
            new Materia { MateriaId=2, MateriaNombre="Programación"},
            new Materia { MateriaId=3, MateriaNombre="Redes"},
            new Materia { MateriaId=4, MateriaNombre="Calculo"}
        };

        IList<Profesor> lstProfesor = new List<Profesor>() 
        {
            new Profesor { ProfesorId=1, ProfesorNombre="Juan Galindo", ProfesorEdad=40, MateriaId=1},
            new Profesor { ProfesorId=2, ProfesorNombre="Guillermo Caro", ProfesorEdad=50, MateriaId=4},
            new Profesor { ProfesorId=3, ProfesorNombre="Nury Rojas", ProfesorEdad=38, MateriaId=2},
            new Profesor { ProfesorId=4, ProfesorNombre="Osmin Ospina", ProfesorEdad=48, MateriaId=2},
            new Profesor { ProfesorId=5, ProfesorNombre="Carlos Sosa", ProfesorEdad=35, MateriaId=3},
            new Profesor { ProfesorId=6, ProfesorNombre="Eduardo Montealegre", ProfesorEdad=40, MateriaId=3},
        };

        public ActionResult Index()
        {
            //Inner Join Query Sintax
            var innerJoinQuery = from p in lstProfesor
                                 join m in lstMateria
                                 on p.MateriaId equals m.MateriaId
                                 select new
                                 {
                                     p.ProfesorId,
                                     p.ProfesorNombre,
                                     m.MateriaNombre
                                 };
            //Inner Join Method Sintax
            var innerJoinMethod = lstProfesor.Join
                                  (
                                    lstMateria,
                                    profesor => profesor.MateriaId,
                                    materia => materia.MateriaId,
                                    (profesor, materia) => new
                                    {
                                        profesor.ProfesorId,
                                        profesor.ProfesorNombre,
                                        materia.MateriaNombre
                                    }
                                  );

            IList<SP_Profesor_Materia> query = new List<SP_Profesor_Materia>();
            foreach(var registros in innerJoinMethod)
            {
                query.Add(new SP_Profesor_Materia { ProfesorId = registros.ProfesorId, ProfesorNombre = registros.ProfesorNombre, MateriaNombre = registros.MateriaNombre });
            }

            return View("Query_Profesor", query.ToList());
        }

    }
}
