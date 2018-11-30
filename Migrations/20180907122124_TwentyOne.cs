using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Sportiada.Data.Migrations
{
    public partial class TwentyOne : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "OutIcon",
                table: "FootballPlayerOuts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InIcon",
                table: "FootballPlayerIns",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OutIcon",
                table: "FootballPlayerOuts");

            migrationBuilder.DropColumn(
                name: "InIcon",
                table: "FootballPlayerIns");
        }
    }
}
