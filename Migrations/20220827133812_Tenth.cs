using Microsoft.EntityFrameworkCore.Migrations;

namespace Sportiada.Data.Migrations
{
    public partial class Tenth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "LeftInSummer",
                table: "FootballSquadPlayer",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "LeftInWinter",
                table: "FootballSquadPlayer",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LeftInSummer",
                table: "FootballSquadPlayer");

            migrationBuilder.DropColumn(
                name: "LeftInWinter",
                table: "FootballSquadPlayer");
        }
    }
}
