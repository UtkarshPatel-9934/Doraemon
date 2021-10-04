using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ThemeDoraemon.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "character",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Character_Name = table.Column<string>(type: "TEXT", nullable: true),
                    Favorite_Colour = table.Column<string>(type: "TEXT", nullable: true),
                    Favorite_Food = table.Column<string>(type: "TEXT", nullable: true),
                    Birth_Date = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_character", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "character");
        }
    }
}
