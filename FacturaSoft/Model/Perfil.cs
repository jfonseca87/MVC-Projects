namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Perfil")]
    public partial class Perfil
    {
        public Perfil()
        {
            Paginas = new List<Pagina>();
            Usuarios = new List<Usuario>();
        }

        [Key]
        public int Perfil_Id { get; set; }

        [Required]
        [StringLength(30)]
        public string Nom_Perfil { get; set; }

        public ICollection<Usuario> Usuarios { get; set; }
        public ICollection<Pagina> Paginas { get; set; }
    }
}
