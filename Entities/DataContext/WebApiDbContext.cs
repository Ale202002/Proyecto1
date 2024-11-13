using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DataContext
{
    public class WebApiDbContext:DbContext
    {
        public WebApiDbContext(DbContextOptions<WebApiDbContext> options) : base(options) 
        {

        }

        public DbSet<Domain.Cliente> Clientes { get; set; }
        public DbSet<Domain.Proyecto> Proyectos { get; set; }
        public DbSet<Domain.Servicio> Servicios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var entidadCliente = modelBuilder.Entity<Domain.Cliente>();
            entidadCliente.ToTable("Clientes");
            entidadCliente.HasKey(e => e.Id);
            entidadCliente.Property(e => e.Id).ValueGeneratedOnAdd();
            entidadCliente.Property(e => e.FechaRegistro).HasDefaultValueSql("CURRENT_TIMESTAMP");

            var entidadProyecto = modelBuilder.Entity<Domain.Proyecto>();
            entidadProyecto.ToTable("Proyectos");
            entidadProyecto.HasKey(e => e.Id);
            entidadProyecto.Property(e => e.Id).ValueGeneratedOnAdd();

            var entidadServicio = modelBuilder.Entity<Domain.Servicio>();
            entidadServicio.ToTable("Servicios");
            entidadServicio.HasKey(e => e.Id);
            entidadServicio.Property(e => e.Id).ValueGeneratedOnAdd();
        }
    }
}
