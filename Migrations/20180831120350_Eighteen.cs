using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Sportiada.Data.Migrations
{
    public partial class Eighteen : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FootballCaochSides_FootballCoaches_CoachId",
                table: "FootballCaochSides");

            migrationBuilder.DropForeignKey(
                name: "FK_FootballCaochSides_FootballSides_SideId",
                table: "FootballCaochSides");

            migrationBuilder.DropForeignKey(
                name: "FK_FootballPlayerSides_FootballPlayers_PlayerId",
                table: "FootballPlayerSides");

            migrationBuilder.DropForeignKey(
                name: "FK_FootballPlayerSides_FootballSides_SideId",
                table: "FootballPlayerSides");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FootballPlayerSides",
                table: "FootballPlayerSides");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FootballCaochSides",
                table: "FootballCaochSides");

            migrationBuilder.RenameTable(
                name: "FootballPlayerSides",
                newName: "FootballSidePlayers");

            migrationBuilder.RenameTable(
                name: "FootballCaochSides",
                newName: "FootballSideCoach");

            migrationBuilder.RenameIndex(
                name: "IX_FootballPlayerSides_PlayerId",
                table: "FootballSidePlayers",
                newName: "IX_FootballSidePlayers_PlayerId");

            migrationBuilder.RenameIndex(
                name: "IX_FootballCaochSides_SideId",
                table: "FootballSideCoach",
                newName: "IX_FootballSideCoach_SideId");

            migrationBuilder.AddColumn<bool>(
                name: "FirstTeam",
                table: "FootballSidePlayers",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Under18",
                table: "FootballSidePlayers",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Under23",
                table: "FootballSidePlayers",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "FootballCoaches",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_FootballSidePlayers",
                table: "FootballSidePlayers",
                columns: new[] { "SideId", "PlayerId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_FootballSideCoach",
                table: "FootballSideCoach",
                columns: new[] { "CoachId", "SideId" });

            migrationBuilder.AddForeignKey(
                name: "FK_FootballSideCoach_FootballCoaches_CoachId",
                table: "FootballSideCoach",
                column: "CoachId",
                principalTable: "FootballCoaches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FootballSideCoach_FootballSides_SideId",
                table: "FootballSideCoach",
                column: "SideId",
                principalTable: "FootballSides",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FootballSidePlayers_FootballPlayers_PlayerId",
                table: "FootballSidePlayers",
                column: "PlayerId",
                principalTable: "FootballPlayers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FootballSidePlayers_FootballSides_SideId",
                table: "FootballSidePlayers",
                column: "SideId",
                principalTable: "FootballSides",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FootballSideCoach_FootballCoaches_CoachId",
                table: "FootballSideCoach");

            migrationBuilder.DropForeignKey(
                name: "FK_FootballSideCoach_FootballSides_SideId",
                table: "FootballSideCoach");

            migrationBuilder.DropForeignKey(
                name: "FK_FootballSidePlayers_FootballPlayers_PlayerId",
                table: "FootballSidePlayers");

            migrationBuilder.DropForeignKey(
                name: "FK_FootballSidePlayers_FootballSides_SideId",
                table: "FootballSidePlayers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FootballSidePlayers",
                table: "FootballSidePlayers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FootballSideCoach",
                table: "FootballSideCoach");

            migrationBuilder.DropColumn(
                name: "FirstTeam",
                table: "FootballSidePlayers");

            migrationBuilder.DropColumn(
                name: "Under18",
                table: "FootballSidePlayers");

            migrationBuilder.DropColumn(
                name: "Under23",
                table: "FootballSidePlayers");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "FootballCoaches");

            migrationBuilder.RenameTable(
                name: "FootballSidePlayers",
                newName: "FootballPlayerSides");

            migrationBuilder.RenameTable(
                name: "FootballSideCoach",
                newName: "FootballCaochSides");

            migrationBuilder.RenameIndex(
                name: "IX_FootballSidePlayers_PlayerId",
                table: "FootballPlayerSides",
                newName: "IX_FootballPlayerSides_PlayerId");

            migrationBuilder.RenameIndex(
                name: "IX_FootballSideCoach_SideId",
                table: "FootballCaochSides",
                newName: "IX_FootballCaochSides_SideId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FootballPlayerSides",
                table: "FootballPlayerSides",
                columns: new[] { "SideId", "PlayerId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_FootballCaochSides",
                table: "FootballCaochSides",
                columns: new[] { "CoachId", "SideId" });

            migrationBuilder.AddForeignKey(
                name: "FK_FootballCaochSides_FootballCoaches_CoachId",
                table: "FootballCaochSides",
                column: "CoachId",
                principalTable: "FootballCoaches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FootballCaochSides_FootballSides_SideId",
                table: "FootballCaochSides",
                column: "SideId",
                principalTable: "FootballSides",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FootballPlayerSides_FootballPlayers_PlayerId",
                table: "FootballPlayerSides",
                column: "PlayerId",
                principalTable: "FootballPlayers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FootballPlayerSides_FootballSides_SideId",
                table: "FootballPlayerSides",
                column: "SideId",
                principalTable: "FootballSides",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
