namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;

    [Table("Curso")]
    public partial class Curso
    {
        public Curso()
        {
            Alumno = new List<Alumno>();
        }

        [Key]
        public int Id_Curso { get; set; }

        [Required]
        [StringLength(100)]
        public string Nombre_Curso { get; set; }

        public virtual ICollection<Alumno> Alumno { get; set; }

        public List<Curso> Todo()
        {
            var cursos = new List<Curso>();

            try
            {
                using(var context = new TestContext())
                {
                    cursos = context.Curso.ToList();
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return cursos;
        }
    }
}
