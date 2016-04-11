//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    public partial class Cliente
    {
        public Cliente()
        {
            this.Facturacion = new HashSet<Facturacion>();
        }
    
        public int IdCliente { get; set; }
        [Required(ErrorMessage="El campo C�dula es obligatorio")]
        public string Cedula { get; set; }
        [Required(ErrorMessage = "El campo Nombres es obligatorio")]
        public string Nombres { get; set; }
        [Required(ErrorMessage = "El campo Apellidos es obligatorio")]
        public string Apellidos { get; set; }
        [Required(ErrorMessage = "Debe selccionar una sede")]
        public Nullable<int> IdSede { get; set; }
        public Nullable<System.DateTime> FechaRegistro { get; set; }
    
        public virtual Sede Sede { get; set; }
        public virtual ICollection<Facturacion> Facturacion { get; set; }

        public Cliente ObtenerCliente(int id)
        {
            Cliente cliente = new Cliente();

            try
            {
                using (var context = new PruebasVariasEntities())
                {
                    cliente = context.Cliente.Find(id);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return cliente;
        }

        public void CUCliente(int id)
        {
            try
            {
                using (var context = new PruebasVariasEntities())
                {
                    if (id == 0)
                    {
                        context.Entry(this).State = System.Data.EntityState.Added;
                        context.SaveChanges();
                    }
                    else 
                    {
                        context.Entry(this).State = System.Data.EntityState.Modified;
                        context.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void borraCliente(int id)
        {
            try
            {
                using (var context = new PruebasVariasEntities())
                {
                    context.Entry(this).State = System.Data.EntityState.Deleted;
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

    }
}
