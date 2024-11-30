using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GameStop.Migrations
{
    /// <inheritdoc />
    public partial class Uno_muchos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ClasificacionId",
                table: "Juegos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Clasificaciones",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clasificaciones", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Juegos_ClasificacionId",
                table: "Juegos",
                column: "ClasificacionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Juegos_Clasificaciones_ClasificacionId",
                table: "Juegos",
                column: "ClasificacionId",
                principalTable: "Clasificaciones",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Juegos_Clasificaciones_ClasificacionId",
                table: "Juegos");

            migrationBuilder.DropTable(
                name: "Clasificaciones");

            migrationBuilder.DropIndex(
                name: "IX_Juegos_ClasificacionId",
                table: "Juegos");

            migrationBuilder.DropColumn(
                name: "ClasificacionId",
                table: "Juegos");
        }
    }
}
