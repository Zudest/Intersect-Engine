using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Intersect.Server.Migrations.Game
{
    public partial class SkillSystem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Skills",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    TimeCreated = table.Column<long>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Icon = table.Column<string>(nullable: true),
                    MaxLevel = table.Column<int>(nullable: false),
                    Order = table.Column<int>(nullable: false),
                    Folder = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    LevelUpAnimation = table.Column<Guid>(nullable: false),
                    LevelMaxAnimation = table.Column<Guid>(nullable: false),
                    Class = table.Column<Guid>(nullable: false),
                    BaseExp = table.Column<long>(nullable: false),
                    ExpIncrease = table.Column<long>(nullable: false),
                    ExperienceOverrides = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skills", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Skills");
        }
    }
}
