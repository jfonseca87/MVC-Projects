namespace Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class PruebaSincoSoftContext : DbContext
    {
        public PruebaSincoSoftContext()
            : base("name=PruebaSincoSoftContext")
        {
           
        }

        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<Bill> Bill { get; set; }
        public virtual DbSet<Product> Product { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            
        }
    }
}
