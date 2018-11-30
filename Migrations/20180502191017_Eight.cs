using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Sportiada.Data.Migrations
{
    public partial class Eight : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Time",
                table: "ResultsAlpineSki",
                newName: "TimeSecondManch");

            migrationBuilder.RenameColumn(
                name: "Stage",
                table: "ResultsAlpineSki",
                newName: "TimeFirstManch");

            migrationBuilder.AddColumn<string>(
                name: "FinalTime",
                table: "ResultsAlpineSki",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FinalTime",
                table: "ResultsAlpineSki");

            migrationBuilder.RenameColumn(
                name: "TimeSecondManch",
                table: "ResultsAlpineSki",
                newName: "Time");

            migrationBuilder.RenameColumn(
                name: "TimeFirstManch",
                table: "ResultsAlpineSki",
                newName: "Stage");
        }
    }
}
