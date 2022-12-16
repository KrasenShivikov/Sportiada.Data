using Microsoft.EntityFrameworkCore.Migrations;

namespace Sportiada.Data.Migrations
{
    public partial class Thirteen : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FootballCoachTransfer_FootballCoaches_CoachId",
                table: "FootballCoachTransfer");

            migrationBuilder.DropForeignKey(
                name: "FK_FootballCoachTransfer_FootballTeams_TeamId1",
                table: "FootballCoachTransfer");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FootballCoachTransfer",
                table: "FootballCoachTransfer");

            migrationBuilder.DropIndex(
                name: "IX_FootballCoachTransfer_TeamId1",
                table: "FootballCoachTransfer");

            migrationBuilder.DropColumn(
                name: "TeamId1",
                table: "FootballCoachTransfer");

            migrationBuilder.RenameTable(
                name: "FootballCoachTransfer",
                newName: "FootballCoachTeams");

            migrationBuilder.RenameIndex(
                name: "IX_FootballCoachTransfer_CoachId",
                table: "FootballCoachTeams",
                newName: "IX_FootballCoachTeams_CoachId");

            migrationBuilder.AlterColumn<int>(
                name: "TeamId",
                table: "FootballCoachTeams",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_FootballCoachTeams",
                table: "FootballCoachTeams",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_FootballCoachTeams_TeamId",
                table: "FootballCoachTeams",
                column: "TeamId");

            migrationBuilder.AddForeignKey(
                name: "FK_FootballCoachTeams_FootballCoaches_CoachId",
                table: "FootballCoachTeams",
                column: "CoachId",
                principalTable: "FootballCoaches",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_FootballCoachTeams_FootballTeams_TeamId",
                table: "FootballCoachTeams",
                column: "TeamId",
                principalTable: "FootballTeams",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FootballCoachTeams_FootballCoaches_CoachId",
                table: "FootballCoachTeams");

            migrationBuilder.DropForeignKey(
                name: "FK_FootballCoachTeams_FootballTeams_TeamId",
                table: "FootballCoachTeams");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FootballCoachTeams",
                table: "FootballCoachTeams");

            migrationBuilder.DropIndex(
                name: "IX_FootballCoachTeams_TeamId",
                table: "FootballCoachTeams");

            migrationBuilder.RenameTable(
                name: "FootballCoachTeams",
                newName: "FootballCoachTransfer");

            migrationBuilder.RenameIndex(
                name: "IX_FootballCoachTeams_CoachId",
                table: "FootballCoachTransfer",
                newName: "IX_FootballCoachTransfer_CoachId");

            migrationBuilder.AlterColumn<string>(
                name: "TeamId",
                table: "FootballCoachTransfer",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "TeamId1",
                table: "FootballCoachTransfer",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_FootballCoachTransfer",
                table: "FootballCoachTransfer",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_FootballCoachTransfer_TeamId1",
                table: "FootballCoachTransfer",
                column: "TeamId1");

            migrationBuilder.AddForeignKey(
                name: "FK_FootballCoachTransfer_FootballCoaches_CoachId",
                table: "FootballCoachTransfer",
                column: "CoachId",
                principalTable: "FootballCoaches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FootballCoachTransfer_FootballTeams_TeamId1",
                table: "FootballCoachTransfer",
                column: "TeamId1",
                principalTable: "FootballTeams",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
