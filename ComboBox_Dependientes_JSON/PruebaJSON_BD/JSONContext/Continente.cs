namespace JSONContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;

    [Table("Continente")]
    public partial class Continente
    {
        public Continente()
        {
            Paises = new HashSet<Pais>();
        }

        [Key]
        public int id_Continente { get; set; }

        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }
       
        public ICollection<Pais> Paises { get; set; }

        public List<Continente> listarContinentes()
        {
            List<Continente> lstContinentes = new List<Continente>();

            try
            {
                using(var context = new MundoContext())
                {
                    lstContinentes = context.Continente.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return lstContinentes;
        }

        public List<Pais> listarPaises(int id)
        {
            List<Pais> lstPaises = new List<Pais>();

            try 
            {
                using( MundoContext context = new MundoContext())
                {
                    lstPaises = context.Pais
                                       .Where(x => x.id_Continente == id)
                                       .ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return lstPaises;
        }
    }
}
