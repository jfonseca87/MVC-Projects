﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using System.Linq;
    
    public partial class PruebasVariasEntities : DbContext
    {
        public PruebasVariasEntities()
            : base("name=PruebasVariasEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Ciudad> Ciudad { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Facturacion> Facturacion { get; set; }
        public DbSet<Sede> Sede { get; set; }
    
        public virtual ObjectResult<TOP5ClientesValor_Result> TOP5ClientesValor()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<TOP5ClientesValor_Result>("TOP5ClientesValor");
        }
    }
}
