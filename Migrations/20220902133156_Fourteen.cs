using Microsoft.EntityFrameworkCore.Migrations;

namespace Sportiada.Data.Migrations
{
    public partial class Fourteen : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FootballCoachTeams_FootballTeams_TeamId",
                table: "FootballCoachTeams");

            migrationBuilder.DropIndex(
                name: "IX_FootballCoachTeams_TeamId",
                table: "FootballCoachTeams");

            migrationBuilder.RenameColumn(
                name: "TeamId",
                table: "FootballCoachTeams",
                newName: "Matches");

            migrationBuilder.AddColumn<int>(
                name: "FootballTeamId",
                table: "FootballCoachTeams",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Team",
                table: "FootballCoachTeams",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TeamLogo",
                table: "FootballCoachTeams",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_FootballCoachTeams_FootballTeamId",
                table: "FootballCoachTeams",
                column: "FootballTeamId");

            migrationBuilder.AddForeignKey(
                name: "FK_FootballCoachTeams_FootballTeams_FootballTeamId",
                table: "FootballCoachTeams",
                column: "FootballTeamId",
                principalTable: "FootballTeams",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FootballCoachTeams_FootballTeams_FootballTeamId",
                table: "FootballCoachTeams");

            migrationBuilder.DropIndex(
                name: "IX_FootballCoachTeams_FootballTeamId",
                table: "FootballCoachTeams");

            migrationBuilder.DropColumn(
                name: "FootballTeamId",
                table: "FootballCoachTeams");

            migrationBuilder.DropColumn(
                name: "Team",
                table: "FootballCoachTeams");

            migrationBuilder.DropColumn(
                name: "TeamLogo",
                table: "FootballCoachTeams");

            migrationBuilder.RenameColumn(
                name: "Matches",
                table: "FootballCoachTeams",
                newName: "TeamId");

            migrationBuilder.CreateIndex(
                name: "IX_FootballCoachTeams_TeamId",
                table: "FootballCoachTeams",
                column: "TeamId");

            migrationBuilder.AddForeignKey(
                name: "FK_FootballCoachTeams_FootballTeams_TeamId",
                table: "FootballCoachTeams",
                column: "TeamId",
                principalTable: "FootballTeams",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
