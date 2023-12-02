using PharmaTracker.Shared;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PharmaTracker.Server.DAL
{
    public class PharmaTracketContext : DbContext
    {
        public PharmaTracketContext(DbContextOptions<PharmaTracketContext> options) : base(options)
        {
        }

        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<Productos> Productos { get; set; }
        public DbSet<DetalleLaboratorioProducto> DetalleLaboratorioProducto { get; set; }
        public DbSet<Facturas> Factura { get; set; }
        public DbSet<Vendedor> Vendedor { get; set; }
        public DbSet<Admin> Admin { get; set; }
        public DbSet<CestaDCompra> CestaDCompra { get; set; }
        public DbSet<AdminTiposTelefonos> AdminTiposTelefonos { get; set; }
        public DbSet<VendedorTiposTelefonos> VendedorTiposTelefonos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<AdminTiposTelefonos>().HasData(new List<AdminTiposTelefonos>()
        {
            new AdminTiposTelefonos(){AdminTipoId=1, AdminDescripcion="Telefono"},
            new AdminTiposTelefonos(){AdminTipoId=2, AdminDescripcion="Celular" },
            new AdminTiposTelefonos(){AdminTipoId=3, AdminDescripcion="Oficina" }
        });

            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<VendedorTiposTelefonos>().HasData(new List<VendedorTiposTelefonos>()
        {
            new VendedorTiposTelefonos(){VendedorTipoId=1, VendedorDescripcion="Telefono"},
            new VendedorTiposTelefonos(){VendedorTipoId=2, VendedorDescripcion="Celular" },
            new VendedorTiposTelefonos(){VendedorTipoId=3, VendedorDescripcion="Oficina" }
        });


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
                    Email = "vendedor@gmail.com",
                    Contraseña = "vendedor"
                });
            modelBuilder.Entity<Admin>().HasData(
                new Admin
                {
                    AdminId = 1,
                    Nombre = "Admin",
                    Dirección = "Calle 789",
                    Email = "admin@gmail.com",
                    Contraseña = "admin"
                });
        }
    }
}
