using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShiftWorx.Migrations
{
    public partial class AddFactoryOption : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Factory_Job_JobOptionId",
                table: "Factory");

            migrationBuilder.DropColumn(
                name: "Language",
                table: "Factory");

            migrationBuilder.DropColumn(
                name: "Locale",
                table: "Factory");

            migrationBuilder.DropColumn(
                name: "TimeZone",
                table: "Factory");

            migrationBuilder.RenameColumn(
                name: "JobOptionId",
                table: "Factory",
                newName: "JobInfoId");

            migrationBuilder.RenameIndex(
                name: "IX_Factory_JobOptionId",
                table: "Factory",
                newName: "IX_Factory_JobInfoId");

            migrationBuilder.AddColumn<string>(
                name: "RemodeAddress",
                table: "Machine",
                type: "nvarchar(64)",
                maxLength: 64,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "FactoryOption",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Language = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Locale = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TimeZone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JsonData = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FactoryId = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FactoryOption", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FactoryOption_Factory_FactoryId",
                        column: x => x.FactoryId,
                        principalTable: "Factory",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_FactoryOption_FactoryId",
                table: "FactoryOption",
                column: "FactoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Factory_Job_JobInfoId",
                table: "Factory",
                column: "JobInfoId",
                principalTable: "Job",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Factory_Job_JobInfoId",
                table: "Factory");

            migrationBuilder.DropTable(
                name: "FactoryOption");

            migrationBuilder.DropColumn(
                name: "RemodeAddress",
                table: "Machine");

            migrationBuilder.RenameColumn(
                name: "JobInfoId",
                table: "Factory",
                newName: "JobOptionId");

            migrationBuilder.RenameIndex(
                name: "IX_Factory_JobInfoId",
                table: "Factory",
                newName: "IX_Factory_JobOptionId");

            migrationBuilder.AddColumn<string>(
                name: "Language",
                table: "Factory",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Locale",
                table: "Factory",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TimeZone",
                table: "Factory",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_Factory_Job_JobOptionId",
                table: "Factory",
                column: "JobOptionId",
                principalTable: "Job",
                principalColumn: "Id");
        }
    }
}
