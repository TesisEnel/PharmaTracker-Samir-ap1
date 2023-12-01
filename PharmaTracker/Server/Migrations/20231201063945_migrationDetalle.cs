using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PharmaTracker.Server.Migrations
{
    /// <inheritdoc />
    public partial class migrationDetalle : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AdminDetalle",
                columns: table => new
                {
                    AdminDetalleId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AdminId = table.Column<int>(type: "INTEGER", nullable: false),
                    AdminTipoId = table.Column<int>(type: "INTEGER", nullable: false),
                    AdminTelefono = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdminDetalle", x => x.AdminDetalleId);
                    table.ForeignKey(
                        name: "FK_AdminDetalle_Admin_AdminId",
                        column: x => x.AdminId,
                        principalTable: "Admin",
                        principalColumn: "AdminId",
                        onDelete: ReferentialAction.Cascade);
                });

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
                name: "VendedorDetalle",
                columns: table => new
                {
                    VendedorDetalleId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    VendedorId = table.Column<int>(type: "INTEGER", nullable: false),
                    VendedorTipoId = table.Column<int>(type: "INTEGER", nullable: false),
                    VendedorTelefono = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VendedorDetalle", x => x.VendedorDetalleId);
                    table.ForeignKey(
                        name: "FK_VendedorDetalle_Vendedor_VendedorId",
                        column: x => x.VendedorId,
                        principalTable: "Vendedor",
                        principalColumn: "VendedorId",
                        onDelete: ReferentialAction.Cascade);
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

            migrationBuilder.CreateIndex(
                name: "IX_AdminDetalle_AdminId",
                table: "AdminDetalle",
                column: "AdminId");

            migrationBuilder.CreateIndex(
                name: "IX_VendedorDetalle_VendedorId",
                table: "VendedorDetalle",
                column: "VendedorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdminDetalle");

            migrationBuilder.DropTable(
                name: "AdminTiposTelefonos");

            migrationBuilder.DropTable(
                name: "VendedorDetalle");

            migrationBuilder.DropTable(
                name: "VendedorTiposTelefonos");
        }
    }
}
