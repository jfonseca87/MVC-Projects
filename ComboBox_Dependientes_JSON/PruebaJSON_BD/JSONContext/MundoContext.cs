namespace JSONContext
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Collections.Generic;

    public partial class MundoContext : DbContext
    {
        public MundoContext()
            : base("name=MundoContext")
        {
            this.Configuration.LazyLoadingEnabled = false; 
        }

        public virtual DbSet<Continente> Continente { get; set; }
        public virtual DbSet<Pais> Pais { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Continente>()
                .HasMany(e => e.Paises)
                .WithRequired(e => e.Continente)
                .HasForeignKey(e => e.id_Continente);
        }
    }
}
