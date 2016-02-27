namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Producto")]
    public partial class Producto
    {
        public Producto()
        {
            Factura = new List<Factura>();
        }

        [Key]
        [StringLength(10)]
        public string Cod_Producto { get; set; }

        [Required]
        [StringLength(50)]
        public string Nom_Producto { get; set; }

        public ICollection<Factura> Factura { get; set; }
    }
}
