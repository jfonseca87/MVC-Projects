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
        [Range(1, 120, ErrorMessage ="La edad esta entre 1 a 120 años")]
        public int Age { get; set; }
        [Required(ErrorMessage ="La dirección es requerida")]
        public string Address { get; set; }
        [RegularExpression(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$", 
            ErrorMessage ="Email invalido")]
        public string Email { get; set; }
    }
}