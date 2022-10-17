using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShiftWorx.Migrations
{
    public partial class AddOperation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Operation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OperationTemplateId = table.Column<int>(type: "int", nullable: false),
                    JobId = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TargetCount = table.Column<int>(type: "int", nullable: true),
                    TargetRunrate = table.Column<double>(type: "float", nullable: true),
                    TargetRuntime = table.Column<double>(type: "float", nullable: true),
                    ExpectedCycleTime = table.Column<double>(type: "float", nullable: true),
                    ClientKey = table.Column<string>(type: "nvarchar(191)", maxLength: 191, nullable: true),
                    EstmatedStartTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Multiplier = table.Column<int>(type: "int", nullable: true),
                    fp_core_Id = table.Column<int>(type: "int", nullable: false),
                    IsOpen = table.Column<bool>(type: "bit", nullable: false),
                    IsArchived = table.Column<bool>(type: "bit", nullable: false),
                    RuntimeScale = table.Column<int>(type: "int", nullable: true),
                    RunRateScale = table.Column<int>(type: "int", nullable: true),
                    Group = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Operation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Operation_Job_JobId",
                        column: x => x.JobId,
                        principalTable: "Job",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Operation_JobId",
                table: "Operation",
                column: "JobId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Operation");
        }
    }
}
