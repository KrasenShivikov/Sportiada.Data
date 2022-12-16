using Microsoft.EntityFrameworkCore.Migrations;

namespace Sportiada.Data.Migrations
{
    public partial class First : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FootballPlayerPicture_FootballPlayers_PlayerId",
                table: "FootballPlayerPicture");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FootballPlayerPicture",
                table: "FootballPlayerPicture");

            migrationBuilder.RenameTable(
                name: "FootballPlayerPicture",
                newName: "FootballPlayerPictures");

            migrationBuilder.RenameIndex(
                name: "IX_FootballPlayerPicture_PlayerId",
                table: "FootballPlayerPictures",
                newName: "IX_FootballPlayerPictures_PlayerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FootballPlayerPictures",
                table: "FootballPlayerPictures",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_FootballPlayerPictures_FootballPlayers_PlayerId",
                table: "FootballPlayerPictures",
                column: "PlayerId",
                principalTable: "FootballPlayers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FootballPlayerPictures_FootballPlayers_PlayerId",
                table: "FootballPlayerPictures");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FootballPlayerPictures",
                table: "FootballPlayerPictures");

            migrationBuilder.RenameTable(
                name: "FootballPlayerPictures",
                newName: "FootballPlayerPicture");

            migrationBuilder.RenameIndex(
                name: "IX_FootballPlayerPictures_PlayerId",
                table: "FootballPlayerPicture",
                newName: "IX_FootballPlayerPicture_PlayerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FootballPlayerPicture",
                table: "FootballPlayerPicture",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_FootballPlayerPicture_FootballPlayers_PlayerId",
                table: "FootballPlayerPicture",
                column: "PlayerId",
                principalTable: "FootballPlayers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
