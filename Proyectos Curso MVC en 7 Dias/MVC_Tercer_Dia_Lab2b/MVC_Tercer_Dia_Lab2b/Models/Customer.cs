using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVC_Tercer_Dia_Lab2b.Models
{
    public class Customer
    {
        [Required(ErrorMessage="El código es requerido")]
        public string Code { get; set; }
        [Required(ErrorMessage = "El nombre es requerido")]
        public string Name { get; set; }
        [Required(ErrorMessage="La cantidad es requerida")]
        public int Amount { get; set; }
    }
}