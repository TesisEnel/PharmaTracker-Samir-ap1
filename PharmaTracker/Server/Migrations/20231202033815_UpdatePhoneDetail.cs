using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PharmaTracker.Server.Migrations
{
    /// <inheritdoc />
    public partial class UpdatePhoneDetail : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CestaDCompra_Clientes_ClienteId",
                table: "CestaDCompra");

            migrationBuilder.DropForeignKey(
                name: "FK_Productos_CestaDCompra_CestaDCompraId",
                table: "Productos");

            migrationBuilder.DropIndex(
                name: "IX_Productos_CestaDCompraId",
                table: "Productos");

            migrationBuilder.DropIndex(
                name: "IX_CestaDCompra_ClienteId",
                table: "CestaDCompra");

            migrationBuilder.DropColumn(
                name: "Teléfono",
                table: "Vendedor");

            migrationBuilder.DropColumn(
                name: "CestaDCompraId",
                table: "Productos");

            migrationBuilder.DropColumn(
                name: "Pago",
                table: "CestaDCompra");

            migrationBuilder.DropColumn(
                name: "AdminTipoId",
                table: "AdminDetalle");

            migrationBuilder.DropColumn(
                name: "Teléfono",
                table: "Admin");

            migrationBuilder.RenameColumn(
                name: "Descuento",
                table: "Factura",
                newName: "TipoPago");

            migrationBuilder.AlterColumn<int>(
                name: "Total",
                table: "Factura",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "TEXT");

            migrationBuilder.AddColumn<int>(
                name: "Cantidad",
                table: "CestaDCompra",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Precio",
                table: "CestaDCompra",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProductoId",
                table: "CestaDCompra",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Total",
                table: "CestaDCompra",
                type: "TEXT",
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CestaDCompra_Productos_ProductoId",
                table: "CestaDCompra");

            migrationBuilder.DropIndex(
                name: "IX_CestaDCompra_ProductoId",
                table: "CestaDCompra");

            migrationBuilder.DropColumn(
                name: "Cantidad",
                table: "CestaDCompra");

            migrationBuilder.DropColumn(
                name: "Precio",
                table: "CestaDCompra");

            migrationBuilder.DropColumn(
                name: "ProductoId",
                table: "CestaDCompra");

            migrationBuilder.DropColumn(
                name: "Total",
                table: "CestaDCompra");

            migrationBuilder.DropColumn(
                name: "AdminTipos",
                table: "AdminDetalle");

            migrationBuilder.RenameColumn(
                name: "TipoPago",
                table: "Factura",
                newName: "Descuento");

            migrationBuilder.AddColumn<string>(
                name: "Teléfono",
                table: "Vendedor",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "CestaDCompraId",
                table: "Productos",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Total",
                table: "Factura",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddColumn<bool>(
                name: "Pago",
                table: "CestaDCompra",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

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

            migrationBuilder.UpdateData(
                table: "Admin",
                keyColumn: "AdminId",
                keyValue: 1,
                column: "Teléfono",
                value: "1234567890");

            migrationBuilder.UpdateData(
                table: "Vendedor",
                keyColumn: "VendedorId",
                keyValue: 1,
                column: "Teléfono",
                value: "0987654321");

            migrationBuilder.CreateIndex(
                name: "IX_Productos_CestaDCompraId",
                table: "Productos",
                column: "CestaDCompraId");

            migrationBuilder.CreateIndex(
                name: "IX_CestaDCompra_ClienteId",
                table: "CestaDCompra",
                column: "ClienteId");

            migrationBuilder.AddForeignKey(
                name: "FK_CestaDCompra_Clientes_ClienteId",
                table: "CestaDCompra",
                column: "ClienteId",
                principalTable: "Clientes",
                principalColumn: "ClienteId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Productos_CestaDCompra_CestaDCompraId",
                table: "Productos",
                column: "CestaDCompraId",
                principalTable: "CestaDCompra",
                principalColumn: "CestaDCompraId");
        }
    }
}
