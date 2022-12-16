using Microsoft.EntityFrameworkCore.Migrations;

namespace Sportiada.Data.Migrations
{
    public partial class sixteen : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FootballGameStatistics_FootballTeams_TeamId",
                table: "FootballGameStatistics");

            migrationBuilder.RenameColumn(
                name: "TeamId",
                table: "FootballGameStatistics",
                newName: "SquadId");

            migrationBuilder.RenameIndex(
                name: "IX_FootballGameStatistics_TeamId",
                table: "FootballGameStatistics",
                newName: "IX_FootballGameStatistics_SquadId");

            migrationBuilder.AddColumn<string>(
                name: "FromDate",
                table: "FootballSquadCoaches",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "LeftInSeason",
                table: "FootballSquadCoaches",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "ToDate",
                table: "FootballSquadCoaches",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BirthPlace",
                table: "FootballCoaches",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_FootballGameStatistics_FootballSquads_SquadId",
                table: "FootballGameStatistics",
                column: "SquadId",
                principalTable: "FootballSquads",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FootballGameStatistics_FootballSquads_SquadId",
                table: "FootballGameStatistics");

            migrationBuilder.DropColumn(
                name: "FromDate",
                table: "FootballSquadCoaches");

            migrationBuilder.DropColumn(
                name: "LeftInSeason",
                table: "FootballSquadCoaches");

            migrationBuilder.DropColumn(
                name: "ToDate",
                table: "FootballSquadCoaches");

            migrationBuilder.DropColumn(
                name: "BirthPlace",
                table: "FootballCoaches");

            migrationBuilder.RenameColumn(
                name: "SquadId",
                table: "FootballGameStatistics",
                newName: "TeamId");

            migrationBuilder.RenameIndex(
                name: "IX_FootballGameStatistics_SquadId",
                table: "FootballGameStatistics",
                newName: "IX_FootballGameStatistics_TeamId");

            migrationBuilder.AddForeignKey(
                name: "FK_FootballGameStatistics_FootballTeams_TeamId",
                table: "FootballGameStatistics",
                column: "TeamId",
                principalTable: "FootballTeams",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
