using Microsoft.EntityFrameworkCore.Migrations;

namespace Sportiada.Data.Migrations
{
    public partial class Twelvth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "FootballCoaches",
                newName: "ShortName");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "FootballCoaches",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "FootballCoaches",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ShortName",
                table: "Countries",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 4);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Countries",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 100);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "FootballCoaches");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "FootballCoaches");

            migrationBuilder.RenameColumn(
                name: "ShortName",
                table: "FootballCoaches",
                newName: "Name");

            migrationBuilder.AlterColumn<string>(
                name: "ShortName",
                table: "Countries",
                maxLength: 4,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Countries",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string));
        }
    }
}
