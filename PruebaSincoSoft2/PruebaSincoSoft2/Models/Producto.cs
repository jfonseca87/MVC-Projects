namespace PruebaSincoSoft2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Producto")]
    public partial class Producto
    {
        public int ID { get; set; }

        [Required(ErrorMessage="El Campo ID es obligatorio")]
        [StringLength(5)]
        public string ProID { get; set; }

        [Required(ErrorMessage="El campo DESCRIPCIÓN es obligatorio")]
        [StringLength(50)]
        public string ProDesc { get; set; }

        [Required(ErrorMessage="El campo VALOR es obligatorio")]
        [Column(TypeName = "money")]
        public decimal? ProValor { get; set; }
    }
}
