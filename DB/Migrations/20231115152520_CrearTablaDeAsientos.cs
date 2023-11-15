using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DB.Migrations
{
    /// <inheritdoc />
    public partial class CrearTablaDeAsientos : Migration
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
                name: "Ciudades",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: false),
                    ImagenUrl = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ciudades", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Vuelos",
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
                    table.PrimaryKey("PK_Vuelos", x => x.id);
                    table.ForeignKey(
                        name: "FK_Vuelos_Ciudades_CiudadDestinoId",
                        column: x => x.CiudadDestinoId,
                        principalTable: "Ciudades",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vuelos_Ciudades_CiudadOrigenId",
                        column: x => x.CiudadOrigenId,
                        principalTable: "Ciudades",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TarjetasVuelo",
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
                    table.PrimaryKey("PK_TarjetasVuelo", x => x.id);
                    table.ForeignKey(
                        name: "FK_TarjetasVuelo_Vuelos_VueloId",
                        column: x => x.VueloId,
                        principalTable: "Vuelos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TarjetasVuelo_VueloId",
                table: "TarjetasVuelo",
                column: "VueloId");

            migrationBuilder.CreateIndex(
                name: "IX_Vuelos_CiudadDestinoId",
                table: "Vuelos",
                column: "CiudadDestinoId");

            migrationBuilder.CreateIndex(
                name: "IX_Vuelos_CiudadOrigenId",
                table: "Vuelos",
                column: "CiudadOrigenId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "asiento");

            migrationBuilder.DropTable(
                name: "TarjetasVuelo");

            migrationBuilder.DropTable(
                name: "Vuelos");

            migrationBuilder.DropTable(
                name: "Ciudades");
        }
    }
}
