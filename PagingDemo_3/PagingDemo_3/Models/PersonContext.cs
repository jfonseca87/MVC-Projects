namespace PagingDemo_3.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class PersonContext : DbContext
    {
        public PersonContext()
            : base("name=PersonContext")
        {
        }

        public virtual DbSet<Person> Person { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>()
                .Property(e => e.Forename)
                .IsUnicode(false);

            modelBuilder.Entity<Person>()
                .Property(e => e.Surname)
                .IsUnicode(false);

            modelBuilder.Entity<Person>()
                .Property(e => e.Country)
                .IsUnicode(false);
        }
    }
}
