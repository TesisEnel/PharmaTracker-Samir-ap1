using PharmaTracker.Shared;
using Microsoft.EntityFrameworkCore;

namespace PharmaTracker.Server.DAL
{
    public class PharmaTracketContext : DbContext
    {
        public PharmaTracketContext(DbContextOptions<PharmaTracketContext> options) : base(options)
        {
        }

        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<Productos> Productos { get; set; }
        public DbSet<DescripcionProductoD> DescripcionProductoD { get; set; }
        public DbSet<ComponentesProductoD> ComponentesProductoD { get; set; }
        public DbSet<Facturas> Factura { get; set; }
        public DbSet<Vendedor> Vendedor { get; set; }
        public DbSet<Admin> Admin { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Clientes>().HasData(
                new Clientes
                    {
                    ClienteId = 1,
                    Nombre = "Juan Perez",
                    Dirección = "Calle 123",
                    Teléfono = "1234567890",
                    Email = "cliente@gmail.com",
                    Contraseña = "cliente"
                    });
            modelBuilder.Entity<Vendedor>().HasData(
                new Vendedor
                {
                    VendedorId = 1,
                    Nombre = "Pedro Castillo",
                    Dirección = "Calle 456",
                    Teléfono = "0987654321",
                    Email = "vendedor@gmail.com",
                    Contraseña = "vendedor"
                });
            modelBuilder.Entity<Admin>().HasData(
                new Admin
                {
                    AdminId = 1,
                    Nombre = "Admin",
                    Dirección = "Calle 789",
                    Teléfono = "1234567890",
                    Email = "admin@gmail.com",
                    Contraseña = "admin"
                });
        }
    }
}
