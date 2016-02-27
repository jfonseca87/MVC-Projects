namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;

    [Table("Pagina")]
    public partial class Pagina
    {
        public Pagina()
        {
            Perfiles = new List<Perfil>();
        }

        [Key]
        public int Pagina_Id { get; set; }

        [Required]
        [StringLength(30)]
        public string Nom_Pagina { get; set; }

        public ICollection<Perfil> Perfiles { get; set; }

        public List<Pagina> traePagina(int id)
        {
            List<Pagina> lstPagina = new List<Pagina>();

            try
            {
                using (var context = new FacturaSoftContext())
                {
                    lstPagina = context.Pagina.SqlQuery("select Pagina.Pagina_Id, Pagina.Nom_Pagina from Pagina inner join PerfilHasPagina on Pagina.Pagina_Id = PerfilHasPagina.Id_Pagina where PerfilHasPagina.Id_Perfil = "+ id).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return lstPagina;
        }
    }
}
