using Microsoft.EntityFrameworkCore.Migrations;

namespace Sportiada.Data.Migrations
{
    public partial class twenty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FootballStadium_FootballTeams_TeamId",
                table: "FootballStadium");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FootballStadium",
                table: "FootballStadium");

            migrationBuilder.RenameTable(
                name: "FootballStadium",
                newName: "FootballStadiums");

            migrationBuilder.RenameIndex(
                name: "IX_FootballStadium_TeamId",
                table: "FootballStadiums",
                newName: "IX_FootballStadiums_TeamId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FootballStadiums",
                table: "FootballStadiums",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_FootballStadiums_FootballTeams_TeamId",
                table: "FootballStadiums",
                column: "TeamId",
                principalTable: "FootballTeams",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FootballStadiums_FootballTeams_TeamId",
                table: "FootballStadiums");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FootballStadiums",
                table: "FootballStadiums");

            migrationBuilder.RenameTable(
                name: "FootballStadiums",
                newName: "FootballStadium");

            migrationBuilder.RenameIndex(
                name: "IX_FootballStadiums_TeamId",
                table: "FootballStadium",
                newName: "IX_FootballStadium_TeamId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FootballStadium",
                table: "FootballStadium",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_FootballStadium_FootballTeams_TeamId",
                table: "FootballStadium",
                column: "TeamId",
                principalTable: "FootballTeams",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
