using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto.Models
{
    public class Profesor
    {
        public int ProfesorId { get; set; }
        public string ProfesorNombre { get; set; }
        public int ProfesorEdad { get; set; }
        public int MateriaId { get; set; }
    }
}