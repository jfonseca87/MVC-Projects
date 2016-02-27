using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVC_Tercer_Dia_Lab2.Models
{
    public class Customer
    {
        [Required(ErrorMessage="Código de Cliente es requerido")]
        public string Code { get; set; }
        [Required(ErrorMessage = "El nombre del Cliente es requerido")]
        public string Name {get; set; }
        [Required(ErrorMessage = "El valor de la compra es requerido")]
        public int Amount { get; set; }
    }
}