using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PharmaTracker.Server.Migrations
{
    /// <inheritdoc />
    public partial class UpdatePhoneDetailVendedor : Migration
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

            migrationBuilder.RenameColumn(
                name: "VendedorTipoId",
                table: "VendedorDetalle",
                newName: "AVendedorIdId");

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
                name: "FK_VendedorDetalle_Vendedor_VendedorId",
                table: "VendedorDetalle");

            migrationBuilder.DropColumn(
                name: "VendedorTipos",
                table: "VendedorDetalle");

            migrationBuilder.RenameColumn(
                name: "AVendedorIdId",
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

            migrationBuilder.InsertData(
                table: "AdminTiposTelefonos",
                columns: new[] { "AdminTipoId", "AdminDescripcion" },
                values: new object[,]
                {
                    { 1, "Telefono" },
                    { 2, "Celular" },
                    { 3, "Oficina" }
                });

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
