namespace PruebaSincoSoft2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Usuarios
    {
        public Usuarios()
        {
            Pedido = new HashSet<Pedido>();
        }

        [Key]
        public int UsuID { get; set; }

        [Required(ErrorMessage="El campo Nombre es obligatorio")]
        [StringLength(50)]
        public string UsuNombre { get; set; }

        [Required(ErrorMessage = "El campo Password es obligatorio")]
        [StringLength(20)]
        public string UsuPass { get; set; }

        public virtual ICollection<Pedido> Pedido { get; set; }
    }
}
