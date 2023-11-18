using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PharmaTracker.Server.Migrations
{
    /// <inheritdoc />
    public partial class ClassProductoUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ComponentesProductoD_Productos_ProductosProductoId",
                table: "ComponentesProductoD");

            migrationBuilder.DropForeignKey(
                name: "FK_DescripcionProductoD_Productos_ProductosProductoId",
                table: "DescripcionProductoD");

            migrationBuilder.DropIndex(
                name: "IX_DescripcionProductoD_ProductosProductoId",
                table: "DescripcionProductoD");

            migrationBuilder.DropIndex(
                name: "IX_ComponentesProductoD_ProductosProductoId",
                table: "ComponentesProductoD");

            migrationBuilder.DropColumn(
                name: "ProductosProductoId",
                table: "DescripcionProductoD");

            migrationBuilder.DropColumn(
                name: "ProductosProductoId",
                table: "ComponentesProductoD");

            migrationBuilder.AddColumn<DateTime>(
                name: "Fecha",
                table: "Productos",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Unidad",
                table: "Productos",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "imagen",
                table: "Productos",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Categoria",
                table: "DescripcionProductoD",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Fecha",
                table: "Productos");

            migrationBuilder.DropColumn(
                name: "Unidad",
                table: "Productos");

            migrationBuilder.DropColumn(
                name: "imagen",
                table: "Productos");

            migrationBuilder.DropColumn(
                name: "Categoria",
                table: "DescripcionProductoD");

            migrationBuilder.AddColumn<int>(
                name: "ProductosProductoId",
                table: "DescripcionProductoD",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProductosProductoId",
                table: "ComponentesProductoD",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_DescripcionProductoD_ProductosProductoId",
                table: "DescripcionProductoD",
                column: "ProductosProductoId");

            migrationBuilder.CreateIndex(
                name: "IX_ComponentesProductoD_ProductosProductoId",
                table: "ComponentesProductoD",
                column: "ProductosProductoId");

            migrationBuilder.AddForeignKey(
                name: "FK_ComponentesProductoD_Productos_ProductosProductoId",
                table: "ComponentesProductoD",
                column: "ProductosProductoId",
                principalTable: "Productos",
                principalColumn: "ProductoId");

            migrationBuilder.AddForeignKey(
                name: "FK_DescripcionProductoD_Productos_ProductosProductoId",
                table: "DescripcionProductoD",
                column: "ProductosProductoId",
                principalTable: "Productos",
                principalColumn: "ProductoId");
        }
    }
}
