using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DB.Migrations
{
    /// <inheritdoc />
    public partial class add_zip_code_to_ciudad : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tarjeta_vuelo");

            migrationBuilder.AddColumn<string>(
                name: "ZipCode",
                table: "ciudad",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ZipCode",
                table: "ciudad");

            migrationBuilder.CreateTable(
                name: "tarjeta_vuelo",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    VueloId = table.Column<int>(type: "INTEGER", nullable: false),
                    CiudadDestinoImgUrl = table.Column<string>(type: "TEXT", nullable: false),
                    HoraLlegada = table.Column<DateTime>(type: "TEXT", nullable: false),
                    HoraSalida = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Precio = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tarjeta_vuelo", x => x.id);
                    table.ForeignKey(
                        name: "FK_tarjeta_vuelo_vuelo_VueloId",
                        column: x => x.VueloId,
                        principalTable: "vuelo",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tarjeta_vuelo_VueloId",
                table: "tarjeta_vuelo",
                column: "VueloId");
        }
    }
}
