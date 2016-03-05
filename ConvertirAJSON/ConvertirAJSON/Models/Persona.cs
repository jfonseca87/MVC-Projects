using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConvertirAJSON.Models
{
    public class Persona
    {
        public int ID { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public int? Edad { get; set; }
        public string Mail { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
    }
}