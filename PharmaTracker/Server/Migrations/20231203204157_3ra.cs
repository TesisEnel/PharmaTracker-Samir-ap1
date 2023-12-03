using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PharmaTracker.Server.Migrations
{
    /// <inheritdoc />
    public partial class _3ra : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "DetalleLaboratorioProducto",
                columns: new[] { "DetalleLaboratorioProductoId", "Cantidad", "Laboratorios", "ProductoId" },
                values: new object[] { 1, 100, "Bayer", 1 });

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2023, 12, 3, 16, 41, 57, 392, DateTimeKind.Local).AddTicks(1541));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DetalleLaboratorioProducto",
                keyColumn: "DetalleLaboratorioProductoId",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2023, 12, 3, 16, 39, 30, 816, DateTimeKind.Local).AddTicks(2035));
        }
    }
}
