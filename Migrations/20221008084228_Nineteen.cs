using Microsoft.EntityFrameworkCore.Migrations;

namespace Sportiada.Data.Migrations
{
    public partial class Nineteen : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FootballGameStatisticCoach_FootballCoaches_CoachId",
                table: "FootballGameStatisticCoach");

            migrationBuilder.DropForeignKey(
                name: "FK_FootballGameStatisticCoach_FootballGameStatistics_GameStatisticId",
                table: "FootballGameStatisticCoach");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FootballGameStatisticCoach",
                table: "FootballGameStatisticCoach");

            migrationBuilder.RenameTable(
                name: "FootballGameStatisticCoach",
                newName: "FootballGameStatisticCoaches");

            migrationBuilder.RenameIndex(
                name: "IX_FootballGameStatisticCoach_GameStatisticId",
                table: "FootballGameStatisticCoaches",
                newName: "IX_FootballGameStatisticCoaches_GameStatisticId");

            migrationBuilder.RenameIndex(
                name: "IX_FootballGameStatisticCoach_CoachId",
                table: "FootballGameStatisticCoaches",
                newName: "IX_FootballGameStatisticCoaches_CoachId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FootballGameStatisticCoaches",
                table: "FootballGameStatisticCoaches",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_FootballGameStatisticCoaches_FootballCoaches_CoachId",
                table: "FootballGameStatisticCoaches",
                column: "CoachId",
                principalTable: "FootballCoaches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FootballGameStatisticCoaches_FootballGameStatistics_GameStatisticId",
                table: "FootballGameStatisticCoaches",
                column: "GameStatisticId",
                principalTable: "FootballGameStatistics",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FootballGameStatisticCoaches_FootballCoaches_CoachId",
                table: "FootballGameStatisticCoaches");

            migrationBuilder.DropForeignKey(
                name: "FK_FootballGameStatisticCoaches_FootballGameStatistics_GameStatisticId",
                table: "FootballGameStatisticCoaches");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FootballGameStatisticCoaches",
                table: "FootballGameStatisticCoaches");

            migrationBuilder.RenameTable(
                name: "FootballGameStatisticCoaches",
                newName: "FootballGameStatisticCoach");

            migrationBuilder.RenameIndex(
                name: "IX_FootballGameStatisticCoaches_GameStatisticId",
                table: "FootballGameStatisticCoach",
                newName: "IX_FootballGameStatisticCoach_GameStatisticId");

            migrationBuilder.RenameIndex(
                name: "IX_FootballGameStatisticCoaches_CoachId",
                table: "FootballGameStatisticCoach",
                newName: "IX_FootballGameStatisticCoach_CoachId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FootballGameStatisticCoach",
                table: "FootballGameStatisticCoach",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_FootballGameStatisticCoach_FootballCoaches_CoachId",
                table: "FootballGameStatisticCoach",
                column: "CoachId",
                principalTable: "FootballCoaches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FootballGameStatisticCoach_FootballGameStatistics_GameStatisticId",
                table: "FootballGameStatisticCoach",
                column: "GameStatisticId",
                principalTable: "FootballGameStatistics",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
