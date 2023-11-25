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
        public DbSet<DetalleLaboratorioProducto> DetalleLaboratorioProducto { get; set; }
        public DbSet<Facturas> Factura { get; set; }
        public DbSet<Vendedor> Vendedor { get; set; }
    }
}
