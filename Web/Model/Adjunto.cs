namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Adjunto")]
    public partial class Adjunto
    {
        [Key]
        public int Id_Adjunto { get; set; }

        [Required]
        [StringLength(100)]
        public string Archivo { get; set; }

        public int Id_Alumno { get; set; }

        public virtual Alumno Alumno { get; set; }
    }
}
