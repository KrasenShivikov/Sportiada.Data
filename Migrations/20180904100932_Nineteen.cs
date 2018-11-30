using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Sportiada.Data.Migrations
{
    public partial class Nineteen : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ProfileName",
                table: "FootballPlayers",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "MainCountry",
                table: "FootballPlayerCountry",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProfileName",
                table: "FootballPlayers");

            migrationBuilder.DropColumn(
                name: "MainCountry",
                table: "FootballPlayerCountry");
        }
    }
}
