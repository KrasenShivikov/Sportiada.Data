using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Sportiada.Data.Migrations
{
    public partial class TwentyThree : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "OnLoan",
                table: "FootballSidePlayers",
                newName: "OnLoanIn");

            migrationBuilder.AddColumn<bool>(
                name: "OnLoamOut",
                table: "FootballSidePlayers",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OnLoamOut",
                table: "FootballSidePlayers");

            migrationBuilder.RenameColumn(
                name: "OnLoanIn",
                table: "FootballSidePlayers",
                newName: "OnLoan");
        }
    }
}
