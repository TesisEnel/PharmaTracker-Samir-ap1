using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PharmaTracker.Server.Migrations
{
    /// <inheritdoc />
    public partial class AddProductoDescribe : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DetalleLaboratorioProducto_Productos_ProductosProductoId",
                table: "DetalleLaboratorioProducto");

            migrationBuilder.DropIndex(
                name: "IX_DetalleLaboratorioProducto_ProductosProductoId",
                table: "DetalleLaboratorioProducto");

            migrationBuilder.DropColumn(
                name: "ProductosProductoId",
                table: "DetalleLaboratorioProducto");

            migrationBuilder.AddColumn<string>(
                name: "Descripcion",
                table: "Productos",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleLaboratorioProducto_ProductoId",
                table: "DetalleLaboratorioProducto",
                column: "ProductoId");

            migrationBuilder.AddForeignKey(
                name: "FK_DetalleLaboratorioProducto_Productos_ProductoId",
                table: "DetalleLaboratorioProducto",
                column: "ProductoId",
                principalTable: "Productos",
                principalColumn: "ProductoId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DetalleLaboratorioProducto_Productos_ProductoId",
                table: "DetalleLaboratorioProducto");

            migrationBuilder.DropIndex(
                name: "IX_DetalleLaboratorioProducto_ProductoId",
                table: "DetalleLaboratorioProducto");

            migrationBuilder.DropColumn(
                name: "Descripcion",
                table: "Productos");

            migrationBuilder.AddColumn<int>(
                name: "ProductosProductoId",
                table: "DetalleLaboratorioProducto",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_DetalleLaboratorioProducto_ProductosProductoId",
                table: "DetalleLaboratorioProducto",
                column: "ProductosProductoId");

            migrationBuilder.AddForeignKey(
                name: "FK_DetalleLaboratorioProducto_Productos_ProductosProductoId",
                table: "DetalleLaboratorioProducto",
                column: "ProductosProductoId",
                principalTable: "Productos",
                principalColumn: "ProductoId");
        }
    }
}
