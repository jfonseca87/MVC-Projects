namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;

    [Table("Usuario")]
    public partial class Usuario
    {
        public Usuario()
        {
            Registros = new List<Registro>();
        }

        [Key]
        public int Usuario_Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Nom_Usuario { get; set; }

        [Required]
        [StringLength(15)]
        public string Nick_Usuario { get; set; }

        [Required]
        [StringLength(50)]
        public string UPassword { get; set; }

        public int? Id_Perfil { get; set; }

        public Perfil Perfil { get; set; }

        public virtual ICollection<Registro> Registros { get; set; }

        public List<Usuario> ConsultaUsuario(string user, string password)
        {
            List<Usuario> usuario = new List<Usuario>();

            try
            {
                using (var context = new FacturaSoftContext())
                {
                    usuario = context.Usuario.Where(x => x.Nick_Usuario == user && x.UPassword == password).ToList();
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return usuario;
        }
    }
}
