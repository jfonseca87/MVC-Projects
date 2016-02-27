namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Registro")]
    public partial class Registro
    {
        [Key]
        public int Id_Registro { get; set; }

        public int? Id_Actividad { get; set; }

        [StringLength(10)]
        public string Proc_Actividad { get; set; }

        [Required]
        [StringLength(1)]
        public string Tipo_Actividad { get; set; }

        public int? Usu_Actividad { get; set; }

        public DateTime? Fecha_Actividad { get; set; }

        public Usuario Usuario { get; set; }

        public void Guardar(int idActividad, string ProActividad, string tActividad, int user)
        {
            try
            {
                using( var context = new FacturaSoftContext())
                {
                    this.Id_Actividad = idActividad;
                    this.Proc_Actividad = ProActividad;
                    this.Tipo_Actividad = tActividad;
                    this.Fecha_Actividad = System.DateTime.Now;
                    this.Usu_Actividad = user;
                    context.Registro.Add(this);
                    context.SaveChanges();
                }
            }catch(Exception ex)
            {
                throw (new Exception(ex.Message));
            }
        }
    }
}
