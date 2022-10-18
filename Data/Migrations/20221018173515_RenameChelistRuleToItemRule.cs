using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShiftWorx.Migrations
{
    public partial class RenameChelistRuleToItemRule : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChecklistItem_ChecklistRule_RuleId",
                table: "ChecklistItem");

            migrationBuilder.DropForeignKey(
                name: "FK_ChecklistTemplateItem_ChecklistTemplateRule_RuleId",
                table: "ChecklistTemplateItem");

            migrationBuilder.DropTable(
                name: "ChecklistRule");

            migrationBuilder.DropTable(
                name: "ChecklistTemplateRule");

            migrationBuilder.CreateTable(
                name: "ChecklistTemplateItemRule",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<int>(type: "int", nullable: false),
                    CriteriaValue = table.Column<double>(type: "float", nullable: false),
                    CriteriaValue2 = table.Column<double>(type: "float", nullable: true),
                    IsCritical = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChecklistTemplateItemRule", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ChecklistItemRule",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TemplateId = table.Column<int>(type: "int", nullable: true),
                    Type = table.Column<int>(type: "int", nullable: false),
                    CriteriaValue = table.Column<double>(type: "float", nullable: false),
                    CriteriaValue2 = table.Column<double>(type: "float", nullable: true),
                    IsCritical = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChecklistItemRule", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChecklistItemRule_ChecklistTemplateItemRule_TemplateId",
                        column: x => x.TemplateId,
                        principalTable: "ChecklistTemplateItemRule",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChecklistItemRule_TemplateId",
                table: "ChecklistItemRule",
                column: "TemplateId");

            migrationBuilder.AddForeignKey(
                name: "FK_ChecklistItem_ChecklistItemRule_RuleId",
                table: "ChecklistItem",
                column: "RuleId",
                principalTable: "ChecklistItemRule",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ChecklistTemplateItem_ChecklistTemplateItemRule_RuleId",
                table: "ChecklistTemplateItem",
                column: "RuleId",
                principalTable: "ChecklistTemplateItemRule",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChecklistItem_ChecklistItemRule_RuleId",
                table: "ChecklistItem");

            migrationBuilder.DropForeignKey(
                name: "FK_ChecklistTemplateItem_ChecklistTemplateItemRule_RuleId",
                table: "ChecklistTemplateItem");

            migrationBuilder.DropTable(
                name: "ChecklistItemRule");

            migrationBuilder.DropTable(
                name: "ChecklistTemplateItemRule");

            migrationBuilder.CreateTable(
                name: "ChecklistTemplateRule",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CriteriaValue = table.Column<double>(type: "float", nullable: false),
                    CriteriaValue2 = table.Column<double>(type: "float", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsCritical = table.Column<bool>(type: "bit", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChecklistTemplateRule", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ChecklistRule",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TemplateId = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CriteriaValue = table.Column<double>(type: "float", nullable: false),
                    CriteriaValue2 = table.Column<double>(type: "float", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsCritical = table.Column<bool>(type: "bit", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChecklistRule", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChecklistRule_ChecklistTemplateRule_TemplateId",
                        column: x => x.TemplateId,
                        principalTable: "ChecklistTemplateRule",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChecklistRule_TemplateId",
                table: "ChecklistRule",
                column: "TemplateId");

            migrationBuilder.AddForeignKey(
                name: "FK_ChecklistItem_ChecklistRule_RuleId",
                table: "ChecklistItem",
                column: "RuleId",
                principalTable: "ChecklistRule",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ChecklistTemplateItem_ChecklistTemplateRule_RuleId",
                table: "ChecklistTemplateItem",
                column: "RuleId",
                principalTable: "ChecklistTemplateRule",
                principalColumn: "Id");
        }
    }
}
