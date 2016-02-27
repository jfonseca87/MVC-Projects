namespace Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class FacturaSoftContext : DbContext
    {
        public FacturaSoftContext()
            : base("name=FacturaSoftContext")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<Factura> Factura { get; set; }
        public virtual DbSet<Pagina> Pagina { get; set; }
        public virtual DbSet<Perfil> Perfil { get; set; }
        public virtual DbSet<Producto> Producto { get; set; }
        public virtual DbSet<Registro> Registro { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pagina>()
                .HasMany(e => e.Perfiles)
                .WithMany(e => e.Paginas)
                .Map(m => m.ToTable("PerfilHasPagina"));

            modelBuilder.Entity<Perfil>()
                .HasMany(e => e.Usuarios)
                .WithRequired(e => e.Perfil)
                .HasForeignKey(e => e.Id_Perfil);

            modelBuilder.Entity<Usuario>()
                .HasMany(e => e.Registros)
                .WithRequired(e => e.Usuario)
                .HasForeignKey(e => e.Usu_Actividad);   
        }
    }
}
