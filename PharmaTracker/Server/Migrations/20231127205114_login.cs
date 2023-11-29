using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PharmaTracker.Server.Migrations
{
    /// <inheritdoc />
    public partial class login : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DescripcionProductoD");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DescripcionProductoD",
                columns: table => new
                {
                    DetalleProductoId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Categoria = table.Column<string>(type: "TEXT", nullable: false),
                    Descripción = table.Column<string>(type: "TEXT", nullable: false),
                    ProductoId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DescripcionProductoD", x => x.DetalleProductoId);
                });
        }
    }
}
