using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Sportiada.Data.Migrations
{
    public partial class twelve : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CompetitionsAlpineSki_DisciplinesAlpineSki_DisciplineAlpineSkiId",
                table: "CompetitionsAlpineSki");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DisciplinesAlpineSki",
                table: "DisciplinesAlpineSki");

            migrationBuilder.RenameTable(
                name: "DisciplinesAlpineSki",
                newName: "AlpineSkiDisciplines");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AlpineSkiDisciplines",
                table: "AlpineSkiDisciplines",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CompetitionsAlpineSki_AlpineSkiDisciplines_DisciplineAlpineSkiId",
                table: "CompetitionsAlpineSki",
                column: "DisciplineAlpineSkiId",
                principalTable: "AlpineSkiDisciplines",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CompetitionsAlpineSki_AlpineSkiDisciplines_DisciplineAlpineSkiId",
                table: "CompetitionsAlpineSki");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AlpineSkiDisciplines",
                table: "AlpineSkiDisciplines");

            migrationBuilder.RenameTable(
                name: "AlpineSkiDisciplines",
                newName: "DisciplinesAlpineSki");

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
    }
}
