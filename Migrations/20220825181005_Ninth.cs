using Microsoft.EntityFrameworkCore.Migrations;

namespace Sportiada.Data.Migrations
{
    public partial class Ninth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "JoinedInSeason",
                table: "FootballSquadPlayer",
                newName: "JoinedInWinter");

            migrationBuilder.AddColumn<bool>(
                name: "JoinedInSummer",
                table: "FootballSquadPlayer",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "JoinedInSummer",
                table: "FootballSquadPlayer");

            migrationBuilder.RenameColumn(
                name: "JoinedInWinter",
                table: "FootballSquadPlayer",
                newName: "JoinedInSeason");
        }
    }
}
