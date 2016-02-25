namespace JSONContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Pais
    {
        [Key]
        public int id_Pais { get; set; }

        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }

        public int id_Continente { get; set; }

        public virtual Continente Continente { get; set; }
    }
}
