using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PharmaTracker.Server.Migrations
{
    /// <inheritdoc />
    public partial class AddCarritoCompra : Migration
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

            migrationBuilder.DropPrimaryKey(
                name: "PK_CestaDCompra",
                table: "CestaDCompra");

            migrationBuilder.DropIndex(
                name: "IX_CestaDCompra_ClienteId",
                table: "CestaDCompra");

            migrationBuilder.DropColumn(
                name: "CestaDCompraId",
                table: "Productos");

            migrationBuilder.DropColumn(
                name: "CestaDCompraId",
                table: "CestaDCompra");

            migrationBuilder.DropColumn(
                name: "Fecha",
                table: "CestaDCompra");

            migrationBuilder.DropColumn(
                name: "Pago",
                table: "CestaDCompra");

            migrationBuilder.RenameColumn(
                name: "TotalProductos",
                table: "CestaDCompra",
                newName: "Precio");

            migrationBuilder.RenameColumn(
                name: "ClienteId",
                table: "CestaDCompra",
                newName: "CarritoCompraId");

            migrationBuilder.AlterColumn<int>(
                name: "CarritoCompraId",
                table: "CestaDCompra",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_CestaDCompra",
                table: "CestaDCompra",
                column: "CarritoCompraId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CestaDCompra",
                table: "CestaDCompra");

            migrationBuilder.RenameColumn(
                name: "Precio",
                table: "CestaDCompra",
                newName: "TotalProductos");

            migrationBuilder.RenameColumn(
                name: "CarritoCompraId",
                table: "CestaDCompra",
                newName: "ClienteId");

            migrationBuilder.AddColumn<int>(
                name: "CestaDCompraId",
                table: "Productos",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ClienteId",
                table: "CestaDCompra",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddColumn<int>(
                name: "CestaDCompraId",
                table: "CestaDCompra",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0)
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Fecha",
                table: "CestaDCompra",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "Pago",
                table: "CestaDCompra",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_CestaDCompra",
                table: "CestaDCompra",
                column: "CestaDCompraId");

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
