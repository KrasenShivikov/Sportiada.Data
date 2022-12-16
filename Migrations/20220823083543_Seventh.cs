using Microsoft.EntityFrameworkCore.Migrations;

namespace Sportiada.Data.Migrations
{
    public partial class Seventh : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FootballSquadPlayer_FootballSquads_PlayerId",
                table: "FootballSquadPlayer");

            migrationBuilder.CreateIndex(
                name: "IX_FootballSquadPlayer_SquadId",
                table: "FootballSquadPlayer",
                column: "SquadId");

            migrationBuilder.AddForeignKey(
                name: "FK_FootballSquadPlayer_FootballSquads_SquadId",
                table: "FootballSquadPlayer",
                column: "SquadId",
                principalTable: "FootballSquads",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FootballSquadPlayer_FootballSquads_SquadId",
                table: "FootballSquadPlayer");

            migrationBuilder.DropIndex(
                name: "IX_FootballSquadPlayer_SquadId",
                table: "FootballSquadPlayer");

            migrationBuilder.AddForeignKey(
                name: "FK_FootballSquadPlayer_FootballSquads_PlayerId",
                table: "FootballSquadPlayer",
                column: "PlayerId",
                principalTable: "FootballSquads",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
