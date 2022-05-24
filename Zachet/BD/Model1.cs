namespace Zachet.BD
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Title> Title { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                .Property(e => e.Surname)
                .IsFixedLength();

            modelBuilder.Entity<Employee>()
                .Property(e => e.Name)
                .IsFixedLength();

            modelBuilder.Entity<Employee>()
                .Property(e => e.Patronymic)
                .IsFixedLength();

            modelBuilder.Entity<Employee>()
                .Property(e => e.Phone)
                .IsFixedLength();

            modelBuilder.Entity<Employee>()
                .Property(e => e.Email)
                .IsFixedLength();

            modelBuilder.Entity<Employee>()
                .HasOptional(e => e.Title)
                .WithRequired(e => e.Employee);

            modelBuilder.Entity<Title>()
                .Property(e => e.Title1)
                .IsFixedLength();
        }
    }
}
