using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PharmaTracker.Server.Migrations
{
    /// <inheritdoc />
    public partial class FixErroresDetallePhone : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VendedorDetalle_Vendedor_VendedorId",
                table: "VendedorDetalle");

            migrationBuilder.DropTable(
                name: "AdminTiposTelefonos");

            migrationBuilder.DropTable(
                name: "VendedorTiposTelefonos");

            migrationBuilder.DropColumn(
                name: "Teléfono",
                table: "Vendedor");

            migrationBuilder.DropColumn(
                name: "AdminTipoId",
                table: "AdminDetalle");

            migrationBuilder.DropColumn(
                name: "Teléfono",
                table: "Admin");

            migrationBuilder.RenameColumn(
                name: "VendedorTipoId",
                table: "VendedorDetalle",
                newName: "VendedorIdId");

            migrationBuilder.AlterColumn<int>(
                name: "VendedorId",
                table: "VendedorDetalle",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddColumn<string>(
                name: "VendedorTipos",
                table: "VendedorDetalle",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<bool>(
                name: "Pago",
                table: "CestaDCompra",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "INTEGER");

            migrationBuilder.AddColumn<int>(
                name: "Cantidad",
                table: "CestaDCompra",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Fecha",
                table: "CestaDCompra",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "PrecioTotal",
                table: "CestaDCompra",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProductoId",
                table: "CestaDCompra",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TotalProductos",
                table: "CestaDCompra",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AdminTipos",
                table: "AdminDetalle",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_CestaDCompra_ProductoId",
                table: "CestaDCompra",
                column: "ProductoId");

            migrationBuilder.AddForeignKey(
                name: "FK_CestaDCompra_Productos_ProductoId",
                table: "CestaDCompra",
                column: "ProductoId",
                principalTable: "Productos",
                principalColumn: "ProductoId");

            migrationBuilder.AddForeignKey(
                name: "FK_VendedorDetalle_Vendedor_VendedorId",
                table: "VendedorDetalle",
                column: "VendedorId",
                principalTable: "Vendedor",
                principalColumn: "VendedorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CestaDCompra_Productos_ProductoId",
                table: "CestaDCompra");

            migrationBuilder.DropForeignKey(
                name: "FK_VendedorDetalle_Vendedor_VendedorId",
                table: "VendedorDetalle");

            migrationBuilder.DropIndex(
                name: "IX_CestaDCompra_ProductoId",
                table: "CestaDCompra");

            migrationBuilder.DropColumn(
                name: "VendedorTipos",
                table: "VendedorDetalle");

            migrationBuilder.DropColumn(
                name: "Cantidad",
                table: "CestaDCompra");

            migrationBuilder.DropColumn(
                name: "Fecha",
                table: "CestaDCompra");

            migrationBuilder.DropColumn(
                name: "PrecioTotal",
                table: "CestaDCompra");

            migrationBuilder.DropColumn(
                name: "ProductoId",
                table: "CestaDCompra");

            migrationBuilder.DropColumn(
                name: "TotalProductos",
                table: "CestaDCompra");

            migrationBuilder.DropColumn(
                name: "AdminTipos",
                table: "AdminDetalle");

            migrationBuilder.RenameColumn(
                name: "VendedorIdId",
                table: "VendedorDetalle",
                newName: "VendedorTipoId");

            migrationBuilder.AlterColumn<int>(
                name: "VendedorId",
                table: "VendedorDetalle",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Teléfono",
                table: "Vendedor",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<bool>(
                name: "Pago",
                table: "CestaDCompra",
                type: "INTEGER",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AdminTipoId",
                table: "AdminDetalle",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Teléfono",
                table: "Admin",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "AdminTiposTelefonos",
                columns: table => new
                {
                    AdminTipoId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AdminDescripcion = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdminTiposTelefonos", x => x.AdminTipoId);
                });

            migrationBuilder.CreateTable(
                name: "VendedorTiposTelefonos",
                columns: table => new
                {
                    VendedorTipoId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    VendedorDescripcion = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VendedorTiposTelefonos", x => x.VendedorTipoId);
                });

            migrationBuilder.UpdateData(
                table: "Admin",
                keyColumn: "AdminId",
                keyValue: 1,
                column: "Teléfono",
                value: "1234567890");

            migrationBuilder.InsertData(
                table: "AdminTiposTelefonos",
                columns: new[] { "AdminTipoId", "AdminDescripcion" },
                values: new object[,]
                {
                    { 1, "Telefono" },
                    { 2, "Celular" },
                    { 3, "Oficina" }
                });

            migrationBuilder.UpdateData(
                table: "Vendedor",
                keyColumn: "VendedorId",
                keyValue: 1,
                column: "Teléfono",
                value: "0987654321");

            migrationBuilder.InsertData(
                table: "VendedorTiposTelefonos",
                columns: new[] { "VendedorTipoId", "VendedorDescripcion" },
                values: new object[,]
                {
                    { 1, "Telefono" },
                    { 2, "Celular" },
                    { 3, "Oficina" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_VendedorDetalle_Vendedor_VendedorId",
                table: "VendedorDetalle",
                column: "VendedorId",
                principalTable: "Vendedor",
                principalColumn: "VendedorId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
