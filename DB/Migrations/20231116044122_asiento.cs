using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DB.Migrations
{
    /// <inheritdoc />
    public partial class asiento : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "asiento",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Numero = table.Column<int>(type: "INTEGER", nullable: false),
                    Clase = table.Column<string>(type: "TEXT", nullable: false),
                    Reservado = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_asiento", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ciudad",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: false),
                    ImagenUrl = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ciudad", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "vuelo",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CiudadOrigenId = table.Column<int>(type: "INTEGER", nullable: false),
                    CiudadDestinoId = table.Column<int>(type: "INTEGER", nullable: false),
                    FechaIda = table.Column<DateTime>(type: "TEXT", nullable: false),
                    FechaVuelta = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Precio = table.Column<decimal>(type: "TEXT", nullable: false),
                    HoraSalida = table.Column<DateTime>(type: "TEXT", nullable: false),
                    HoraLlegada = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vuelo", x => x.id);
                    table.ForeignKey(
                        name: "FK_vuelo_ciudad_CiudadDestinoId",
                        column: x => x.CiudadDestinoId,
                        principalTable: "ciudad",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_vuelo_ciudad_CiudadOrigenId",
                        column: x => x.CiudadOrigenId,
                        principalTable: "ciudad",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tarjeta_vuelo",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    VueloId = table.Column<int>(type: "INTEGER", nullable: false),
                    CiudadDestinoImgUrl = table.Column<string>(type: "TEXT", nullable: false),
                    Precio = table.Column<decimal>(type: "TEXT", nullable: false),
                    HoraSalida = table.Column<DateTime>(type: "TEXT", nullable: false),
                    HoraLlegada = table.Column<DateTime>(type: "TEXT", nullable: false)
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

            migrationBuilder.CreateIndex(
                name: "IX_vuelo_CiudadDestinoId",
                table: "vuelo",
                column: "CiudadDestinoId");

            migrationBuilder.CreateIndex(
                name: "IX_vuelo_CiudadOrigenId",
                table: "vuelo",
                column: "CiudadOrigenId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "asiento");

            migrationBuilder.DropTable(
                name: "tarjeta_vuelo");

            migrationBuilder.DropTable(
                name: "vuelo");

            migrationBuilder.DropTable(
                name: "ciudad");
        }
    }
}
