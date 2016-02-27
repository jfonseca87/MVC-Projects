namespace PruebaSincoSoft2.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class SincoSoftContext : DbContext
    {
        public SincoSoftContext()
            : base("name=SincoSoftContext")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        public virtual DbSet<Pedido> Pedido { get; set; }
        public virtual DbSet<Producto> Producto { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuarios>()
                .HasMany(e => e.Pedido)
                .WithOptional(e => e.Usuarios)
                .HasForeignKey(e => e.PedUsu)
                .WillCascadeOnDelete();
        }
    }
}
