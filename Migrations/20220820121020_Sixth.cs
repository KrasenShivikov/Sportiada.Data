using Microsoft.EntityFrameworkCore.Migrations;

namespace Sportiada.Data.Migrations
{
    public partial class Sixth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SquadPlayers_FootballPlayers_PlayerId",
                table: "SquadPlayers");

            migrationBuilder.DropForeignKey(
                name: "FK_SquadPlayers_FootballSquads_PlayerId",
                table: "SquadPlayers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SquadPlayers",
                table: "SquadPlayers");

            migrationBuilder.RenameTable(
                name: "SquadPlayers",
                newName: "FootballSquadPlayer");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FootballSquadPlayer",
                table: "FootballSquadPlayer",
                columns: new[] { "PlayerId", "SquadId" });

            migrationBuilder.AddForeignKey(
                name: "FK_FootballSquadPlayer_FootballPlayers_PlayerId",
                table: "FootballSquadPlayer",
                column: "PlayerId",
                principalTable: "FootballPlayers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FootballSquadPlayer_FootballSquads_PlayerId",
                table: "FootballSquadPlayer",
                column: "PlayerId",
                principalTable: "FootballSquads",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FootballSquadPlayer_FootballPlayers_PlayerId",
                table: "FootballSquadPlayer");

            migrationBuilder.DropForeignKey(
                name: "FK_FootballSquadPlayer_FootballSquads_PlayerId",
                table: "FootballSquadPlayer");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FootballSquadPlayer",
                table: "FootballSquadPlayer");

            migrationBuilder.RenameTable(
                name: "FootballSquadPlayer",
                newName: "SquadPlayers");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SquadPlayers",
                table: "SquadPlayers",
                columns: new[] { "PlayerId", "SquadId" });

            migrationBuilder.AddForeignKey(
                name: "FK_SquadPlayers_FootballPlayers_PlayerId",
                table: "SquadPlayers",
                column: "PlayerId",
                principalTable: "FootballPlayers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SquadPlayers_FootballSquads_PlayerId",
                table: "SquadPlayers",
                column: "PlayerId",
                principalTable: "FootballSquads",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
