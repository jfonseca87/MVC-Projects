using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MvcPerson.Models
{
    public class Person
    {
        [Required(ErrorMessage = "El ID es requerido")]
        public int Id { get; set; }
        [Required(ErrorMessage="El nombre es requerido")]
        public string Name { get; set; }
        public int Age { get; set; }
    }
}