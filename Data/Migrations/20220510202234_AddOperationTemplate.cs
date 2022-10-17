using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShiftWorx.Migrations
{
    public partial class AddOperationTemplate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Operation");

            migrationBuilder.DropColumn(
                name: "IsArchived",
                table: "JobTemplate");

            migrationBuilder.DropColumn(
                name: "IsOpen",
                table: "JobTemplate");

            migrationBuilder.DropColumn(
                name: "multiplier",
                table: "JobTemplate");

            migrationBuilder.RenameColumn(
                name: "client_key",
                table: "JobTemplate",
                newName: "ClientKey");

            migrationBuilder.CreateTable(
                name: "OperationTemplate",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JobTemplateId = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Group = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    ClientKey = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fp_core_Id = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperationTemplate", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OperationTemplate_JobTemplate_JobTemplateId",
                        column: x => x.JobTemplateId,
                        principalTable: "JobTemplate",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_OperationTemplate_JobTemplateId",
                table: "OperationTemplate",
                column: "JobTemplateId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OperationTemplate");

            migrationBuilder.RenameColumn(
                name: "ClientKey",
                table: "JobTemplate",
                newName: "client_key");

            migrationBuilder.AddColumn<bool>(
                name: "IsArchived",
                table: "JobTemplate",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsOpen",
                table: "JobTemplate",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "multiplier",
                table: "JobTemplate",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Operation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    JobTemplateId = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Operation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Operation_JobTemplate_JobTemplateId",
                        column: x => x.JobTemplateId,
                        principalTable: "JobTemplate",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Operation_JobTemplateId",
                table: "Operation",
                column: "JobTemplateId");
        }
    }
}
