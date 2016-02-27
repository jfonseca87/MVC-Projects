namespace PagingDemo_3.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Person")]
    public partial class Person
    {
        public int PersonId { get; set; }

        [Required(ErrorMessage = "The field Forename is required")]
        [StringLength(15)]
        public string Forename { get; set; }

        [Required(ErrorMessage = "The field Suraname is required" )]
        [StringLength(15)]
        public string Surname { get; set; }

        [Required(ErrorMessage = "The field Location is required")]
        [StringLength(20)]
        public string Country { get; set; }
    }
}
