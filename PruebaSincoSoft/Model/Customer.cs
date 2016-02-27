namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;

    [Table("Customer")]
    public partial class Customer
    {
        [Key]
        [StringLength(10)]
        public string Code { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [Column(TypeName = "money")]
        public decimal? Amount { get; set; }

        public void Guardar()
        {
            try 
            {
                using (var context = new PruebaSincoSoftContext())
                {
                    context.Customer.Add(this);
                    context.SaveChanges();
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Customer> listarCustomer()
        {
            List<Customer> lstCustomer = new List<Customer>();

            try
            {
                using (var context = new PruebaSincoSoftContext())
                {
                    lstCustomer = context.Customer.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return lstCustomer;
        }
    }
}
