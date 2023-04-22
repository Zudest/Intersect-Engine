using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Intersect.Server.Migrations
{
    public partial class SkillSystem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Player_Skills",
                columns: table => new
                {
                    SkillId = table.Column<Guid>(nullable: false),
                    Level = table.Column<int>(nullable: false),
                    Experience = table.Column<long>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    Id = table.Column<Guid>(nullable: false),
                    PlayerId = table.Column<Guid>(nullable: false),
                    Slot = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Player_Skills", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Player_Skills_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Players",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Player_Skills_PlayerId",
                table: "Player_Skills",
                column: "PlayerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Player_Skills");
        }
    }
}
