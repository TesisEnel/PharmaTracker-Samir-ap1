using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PharmaTracker.Server.Migrations
{
    /// <inheritdoc />
    public partial class actualizacion : Migration
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
                name: "Clientes",
                columns: table => new
                {
                    ClienteId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: false),
                    Dirección = table.Column<string>(type: "TEXT", nullable: false),
                    Teléfono = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    Contraseña = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.ClienteId);
                });

            migrationBuilder.CreateTable(
                name: "Factura",
                columns: table => new
                {
                    FacturaId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TipoFactura = table.Column<string>(type: "TEXT", nullable: false),
                    NCF = table.Column<int>(type: "INTEGER", nullable: false),
                    Fecha = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ClienteId = table.Column<int>(type: "INTEGER", nullable: false),
                    Descuento = table.Column<decimal>(type: "TEXT", nullable: false),
                    Total = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Factura", x => x.FacturaId);
                });

            migrationBuilder.CreateTable(
                name: "Vendedor",
                columns: table => new
                {
                    VendedorId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: false),
                    Dirección = table.Column<string>(type: "TEXT", nullable: false),
                    Teléfono = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    Contraseña = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendedor", x => x.VendedorId);
                });

            migrationBuilder.CreateTable(
                name: "Productos",
                columns: table => new
                {
                    ProductoId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Fecha = table.Column<DateTime>(type: "TEXT", nullable: false),
                    NombreProducto = table.Column<string>(type: "TEXT", nullable: false),
                    Existencia = table.Column<int>(type: "INTEGER", nullable: false),
                    Unidad = table.Column<string>(type: "TEXT", nullable: false),
                    Categoria = table.Column<string>(type: "TEXT", nullable: false),
                    FacturasFacturaId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productos", x => x.ProductoId);
                    table.ForeignKey(
                        name: "FK_Productos_Factura_FacturasFacturaId",
                        column: x => x.FacturasFacturaId,
                        principalTable: "Factura",
                        principalColumn: "FacturaId");
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

            migrationBuilder.CreateIndex(
                name: "IX_Productos_FacturasFacturaId",
                table: "Productos",
                column: "FacturasFacturaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admin");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "DetalleLaboratorioProducto");

            migrationBuilder.DropTable(
                name: "Vendedor");

            migrationBuilder.DropTable(
                name: "Productos");

            migrationBuilder.DropTable(
                name: "Factura");
        }
    }
}
