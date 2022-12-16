using Microsoft.EntityFrameworkCore.Migrations;

namespace Sportiada.Data.Migrations
{
    public partial class Seventeen : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstHalf",
                table: "FootballPlayerOuts");

            migrationBuilder.DropColumn(
                name: "Minute",
                table: "FootballPlayerOuts");

            migrationBuilder.DropColumn(
                name: "FirstHalf",
                table: "FootballPlayerIns");

            migrationBuilder.DropColumn(
                name: "Minute",
                table: "FootballPlayerIns");

            migrationBuilder.AddColumn<int>(
                name: "Minute",
                table: "FootballSubstitutes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "firstHalf",
                table: "FootballSubstitutes",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Minute",
                table: "FootballSubstitutes");

            migrationBuilder.DropColumn(
                name: "firstHalf",
                table: "FootballSubstitutes");

            migrationBuilder.AddColumn<bool>(
                name: "FirstHalf",
                table: "FootballPlayerOuts",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "Minute",
                table: "FootballPlayerOuts",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "FirstHalf",
                table: "FootballPlayerIns",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "Minute",
                table: "FootballPlayerIns",
                nullable: false,
                defaultValue: 0);
        }
    }
}
