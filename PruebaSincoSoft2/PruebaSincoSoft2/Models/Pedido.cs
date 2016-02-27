namespace PruebaSincoSoft2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Pedido")]
    public partial class Pedido
    {
        [Key]
        public int PedID { get; set; }
        
        public int? PedUsu { get; set; }

        public string PedProd { get; set; }

        [Column(TypeName = "money")]
        public decimal? PedVrUnit { get; set; }

        [Required(ErrorMessage = "Debe ingresar una cantidad")]
        public double? PedCant { get; set; }

        [Column(TypeName = "money")]
        public decimal? PedSubTot { get; set; }

        public double? PedIVA { get; set; }

        [Column(TypeName = "money")]
        public decimal? PedTotal { get; set; }

        public virtual Usuarios Usuarios { get; set; }
    }
}
