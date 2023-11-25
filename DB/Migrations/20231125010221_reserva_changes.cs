using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DB.Migrations
{
    /// <inheritdoc />
    public partial class reserva_changes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "asiento",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "VueloId",
                table: "asiento",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_asiento_UserId",
                table: "asiento",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_asiento_VueloId",
                table: "asiento",
                column: "VueloId");

            migrationBuilder.AddForeignKey(
                name: "FK_asiento_user_UserId",
                table: "asiento",
                column: "UserId",
                principalTable: "user",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_asiento_vuelo_VueloId",
                table: "asiento",
                column: "VueloId",
                principalTable: "vuelo",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_asiento_user_UserId",
                table: "asiento");

            migrationBuilder.DropForeignKey(
                name: "FK_asiento_vuelo_VueloId",
                table: "asiento");

            migrationBuilder.DropIndex(
                name: "IX_asiento_UserId",
                table: "asiento");

            migrationBuilder.DropIndex(
                name: "IX_asiento_VueloId",
                table: "asiento");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "asiento");

            migrationBuilder.DropColumn(
                name: "VueloId",
                table: "asiento");
        }
    }
}
