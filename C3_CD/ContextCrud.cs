using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using C4_EN;
namespace C3_CD
{
    public class ContextCrud : DbContext
    {
        public ContextCrud(DbContextOptions<ContextCrud> options) : base(options) { }

        public DbSet<C4_EN.Proyecto> Proyectos { get; set; }
        public DbSet<C4_EN.Servicio> Servicios { get; set; }
        public DbSet<C4_EN.Cliente> Clientes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var entidadProyecto = modelBuilder.Entity<C4_EN.Proyecto>();
            entidadProyecto.ToTable("Proyectos");
            entidadProyecto.HasKey(e => e.Id);
            entidadProyecto.Property(e => e.Id).ValueGeneratedOnAdd();

            var entidadServicio = modelBuilder.Entity<C4_EN.Servicio>();
            entidadServicio.ToTable("Servicios");
            entidadServicio.HasKey(e => e.Id);
            entidadServicio.Property(e => e.Id).ValueGeneratedOnAdd();

            var entidadCliente = modelBuilder.Entity<C4_EN.Cliente>();
            entidadCliente.ToTable("Clientes");
            entidadCliente.HasKey(e => e.Id);
            entidadCliente.Property(e => e.Id).ValueGeneratedOnAdd();
        }
    }
}
