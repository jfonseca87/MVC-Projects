using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PruebaJSON.Models
{
    public class Pais
    {
        public int Pais_Id { get; set; }
        public string NPais { get; set; }
        public int Continente_Id { get; set; }

        public Continente Contintente { get; set; }
    }
}