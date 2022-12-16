using Microsoft.EntityFrameworkCore.Migrations;

namespace Sportiada.Data.Migrations
{
    public partial class Second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FootballGameReferees_FootballRefereeType_TypeId",
                table: "FootballGameReferees");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FootballRefereeType",
                table: "FootballRefereeType");

            migrationBuilder.RenameTable(
                name: "FootballRefereeType",
                newName: "FootballRefereeTypes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FootballRefereeTypes",
                table: "FootballRefereeTypes",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_FootballGameReferees_FootballRefereeTypes_TypeId",
                table: "FootballGameReferees",
                column: "TypeId",
                principalTable: "FootballRefereeTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FootballGameReferees_FootballRefereeTypes_TypeId",
                table: "FootballGameReferees");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FootballRefereeTypes",
                table: "FootballRefereeTypes");

            migrationBuilder.RenameTable(
                name: "FootballRefereeTypes",
                newName: "FootballRefereeType");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FootballRefereeType",
                table: "FootballRefereeType",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_FootballGameReferees_FootballRefereeType_TypeId",
                table: "FootballGameReferees",
                column: "TypeId",
                principalTable: "FootballRefereeType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
