namespace WebAPI.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DBModels : DbContext
    {
        public DBModels()
            : base("name=DBModels")
        {
        }

        public virtual DbSet<Persona> Persona { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Persona>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Persona>()
                .Property(e => e.Direccion)
                .IsUnicode(false);

            modelBuilder.Entity<Persona>()
                .Property(e => e.Telefono)
                .IsUnicode(false);

            modelBuilder.Entity<Persona>()
                .Property(e => e.Cedula)
                .IsUnicode(false);
        }
    }
}
