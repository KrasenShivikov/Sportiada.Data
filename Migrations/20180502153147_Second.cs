using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Sportiada.Data.Migrations
{
    public partial class Second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CompetitionsAlpineSki_DisciplineAlpineSkis_DisciplineAlpineSkiId",
                table: "CompetitionsAlpineSki");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DisciplineAlpineSkis",
                table: "DisciplineAlpineSkis");

            migrationBuilder.RenameTable(
                name: "DisciplineAlpineSkis",
                newName: "DisciplinesAlpineSki");

            migrationBuilder.AddColumn<string>(
                name: "Season",
                table: "CompetitionsAlpineSki",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_DisciplinesAlpineSki",
                table: "DisciplinesAlpineSki",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CompetitionsAlpineSki_DisciplinesAlpineSki_DisciplineAlpineSkiId",
                table: "CompetitionsAlpineSki",
                column: "DisciplineAlpineSkiId",
                principalTable: "DisciplinesAlpineSki",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CompetitionsAlpineSki_DisciplinesAlpineSki_DisciplineAlpineSkiId",
                table: "CompetitionsAlpineSki");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DisciplinesAlpineSki",
                table: "DisciplinesAlpineSki");

            migrationBuilder.DropColumn(
                name: "Season",
                table: "CompetitionsAlpineSki");

            migrationBuilder.RenameTable(
                name: "DisciplinesAlpineSki",
                newName: "DisciplineAlpineSkis");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DisciplineAlpineSkis",
                table: "DisciplineAlpineSkis",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CompetitionsAlpineSki_DisciplineAlpineSkis_DisciplineAlpineSkiId",
                table: "CompetitionsAlpineSki",
                column: "DisciplineAlpineSkiId",
                principalTable: "DisciplineAlpineSkis",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
