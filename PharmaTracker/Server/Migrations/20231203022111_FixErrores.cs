using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PharmaTracker.Server.Migrations
{
    /// <inheritdoc />
    public partial class FixErrores : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Precio",
                table: "CestaDCompra");

            migrationBuilder.RenameColumn(
                name: "PrecioTotal",
                table: "CestaDCompra",
                newName: "SesionId");

            migrationBuilder.AlterColumn<int>(
                name: "Cantidad",
                table: "CestaDCompra",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Comentario",
                table: "CestaDCompra",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "SesionDTO",
                columns: table => new
                {
                    SesionId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: true),
                    Correo = table.Column<string>(type: "TEXT", nullable: true),
                    Rol = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SesionDTO", x => x.SesionId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CestaDCompra_SesionId",
                table: "CestaDCompra",
                column: "SesionId");

            migrationBuilder.AddForeignKey(
                name: "FK_CestaDCompra_SesionDTO_SesionId",
                table: "CestaDCompra",
                column: "SesionId",
                principalTable: "SesionDTO",
                principalColumn: "SesionId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CestaDCompra_SesionDTO_SesionId",
                table: "CestaDCompra");

            migrationBuilder.DropTable(
                name: "SesionDTO");

            migrationBuilder.DropIndex(
                name: "IX_CestaDCompra_SesionId",
                table: "CestaDCompra");

            migrationBuilder.DropColumn(
                name: "Comentario",
                table: "CestaDCompra");

            migrationBuilder.RenameColumn(
                name: "SesionId",
                table: "CestaDCompra",
                newName: "PrecioTotal");

            migrationBuilder.AlterColumn<int>(
                name: "Cantidad",
                table: "CestaDCompra",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddColumn<int>(
                name: "Precio",
                table: "CestaDCompra",
                type: "INTEGER",
                nullable: true);
        }
    }
}
