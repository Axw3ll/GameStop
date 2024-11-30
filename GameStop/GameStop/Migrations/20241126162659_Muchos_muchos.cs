using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GameStop.Migrations
{
    /// <inheritdoc />
    public partial class Muchos_muchos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Personajes",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personajes", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "JuegoPersonaje",
                columns: table => new
                {
                    Juegosid = table.Column<int>(type: "int", nullable: false),
                    Personajesid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JuegoPersonaje", x => new { x.Juegosid, x.Personajesid });
                    table.ForeignKey(
                        name: "FK_JuegoPersonaje_Juegos_Juegosid",
                        column: x => x.Juegosid,
                        principalTable: "Juegos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JuegoPersonaje_Personajes_Personajesid",
                        column: x => x.Personajesid,
                        principalTable: "Personajes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_JuegoPersonaje_Personajesid",
                table: "JuegoPersonaje",
                column: "Personajesid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "JuegoPersonaje");

            migrationBuilder.DropTable(
                name: "Personajes");
        }
    }
}
