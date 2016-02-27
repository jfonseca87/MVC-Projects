namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;
    using System.Data.SqlClient;

    [Table("Alumno")]
    public partial class Alumno
    {
        public Alumno()
        {
            Cursos = new List<Curso>();
        }

        [Key]
        public int Id_Alumno { get; set; }

        [Required(ErrorMessage="Debe ingresar un nombre")]
        [StringLength(50)]
        public string Nombre_Alumno { get; set; }

        [Required(ErrorMessage = "Debe ingresar un apellido")]
        [StringLength(50)]
        public string Apellido_Alumno { get; set; }

        public virtual ICollection<Curso> Cursos { get; set; }
        public virtual ICollection<Adjunto> Adjuntos { get; set; }

        public List<Alumno> Listar()
        {
            var alumnos = new List<Alumno>();

            try
            {
                using(var context = new TestContext())
                {
                    alumnos = context.Alumno.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return alumnos;
        }

        public Alumno Obtener(int id)
        {
            var alumno = new Alumno();

            try 
            {
                using(var context = new TestContext())
                {
                    alumno = context.Alumno
                                    .Include("Cursos")
                                    .Where(x => x.Id_Alumno == id)
                                    .Single();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return alumno;
        }

        public void Guardar()
        {
            try
            {
                using(var context = new TestContext())
                {
                    if(this.Id_Alumno == 0)
                    {
                        context.Entry(this).State = System.Data.Entity.EntityState.Added;
                    }
                    else
                    {
                        context.Database.ExecuteSqlCommand(
                            "DELETE FROM AlumnoCurso WHERE Alumno_Id = @id",
                            new SqlParameter("id", this.Id_Alumno)
                        );

                        var CursosBK = this.Cursos;

                        this.Cursos = null;
                        context.Entry(this).State = System.Data.Entity.EntityState.Modified;
                        this.Cursos = CursosBK;

                    }

                    foreach(var c in this.Cursos)
                    {
                        context.Entry(c).State = System.Data.Entity.EntityState.Unchanged;
                    }

                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Eliminar(int id)
        {
            try
            {
                using(var context = new TestContext())
                {
                    context.Entry(new Alumno { Id_Alumno = id }).State = System.Data.Entity.EntityState.Deleted;
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void SubirArchivo(Adjunto adjunto)
        {

        }
    }
}
