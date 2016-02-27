namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Factura")]
    public partial class Factura
    {
        [Key]
        public int Id_Factura { get; set; }

        public int? Cliente_Id { get; set; }

        [StringLength(10)]
        public string Producto_Cod { get; set; }

        public int? Cant_Producto { get; set; }

        [Column(TypeName = "money")]
        public decimal? Subtotal { get; set; }

        [Column(TypeName = "money")]
        public decimal? IVA { get; set; }

        [Column(TypeName = "money")]
        public decimal? Total { get; set; }

        public virtual Cliente Cliente { get; set; }

        public virtual Producto Producto { get; set; }
    }
}
