using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PharmaTracker.Server.Migrations
{
    /// <inheritdoc />
    public partial class Tablaadmin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admin",
                columns: table => new
                {
                    AdminId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: false),
                    Dirección = table.Column<string>(type: "TEXT", nullable: false),
                    Teléfono = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    Contraseña = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admin", x => x.AdminId);
                });

            migrationBuilder.CreateTable(
                name: "DetalleLaboratorioProducto",
                columns: table => new
                {
                    DetalleLaboratorioProductoId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ProductoId = table.Column<int>(type: "INTEGER", nullable: false),
                    Laboratorios = table.Column<string>(type: "TEXT", nullable: false),
                    Cantidad = table.Column<int>(type: "INTEGER", nullable: false),
                    Precio = table.Column<int>(type: "INTEGER", nullable: false),
                    imagen = table.Column<string>(type: "TEXT", nullable: true),
                    ProductosProductoId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetalleLaboratorioProducto", x => x.DetalleLaboratorioProductoId);
                    table.ForeignKey(
                        name: "FK_DetalleLaboratorioProducto_Productos_ProductosProductoId",
                        column: x => x.ProductosProductoId,
                        principalTable: "Productos",
                        principalColumn: "ProductoId");
                });

            migrationBuilder.InsertData(
                table: "Admin",
                columns: new[] { "AdminId", "Contraseña", "Dirección", "Email", "Nombre", "Teléfono" },
                values: new object[] { 1, "admin", "Calle 789", "admin@gmail.com", "Admin", "1234567890" });

            migrationBuilder.InsertData(
                table: "Clientes",
                columns: new[] { "ClienteId", "Contraseña", "Dirección", "Email", "Nombre", "Teléfono" },
                values: new object[] { 1, "cliente", "Calle 123", "cliente@gmail.com", "Juan Perez", "1234567890" });

            migrationBuilder.InsertData(
                table: "Vendedor",
                columns: new[] { "VendedorId", "Contraseña", "Dirección", "Email", "Nombre", "Teléfono" },
                values: new object[] { 1, "vendedor", "Calle 456", "vendedor@gmail.com", "Pedro Castillo", "0987654321" });

            migrationBuilder.CreateIndex(
                name: "IX_DetalleLaboratorioProducto_ProductosProductoId",
                table: "DetalleLaboratorioProducto",
                column: "ProductosProductoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admin");

            migrationBuilder.DropTable(
                name: "DetalleLaboratorioProducto");

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Vendedor",
                keyColumn: "VendedorId",
                keyValue: 1);
        }
    }
}
