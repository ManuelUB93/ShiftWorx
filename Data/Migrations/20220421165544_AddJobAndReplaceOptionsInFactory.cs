using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShiftWorx.Migrations
{
    public partial class AddJobAndReplaceOptionsInFactory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExpectedCycleTime",
                table: "Factory");

            migrationBuilder.DropColumn(
                name: "ExpectedCycleTimeDeviation",
                table: "Factory");

            migrationBuilder.DropColumn(
                name: "TargetCount",
                table: "Factory");

            migrationBuilder.DropColumn(
                name: "TargetRunRate",
                table: "Factory");

            migrationBuilder.DropColumn(
                name: "TargetRunTime",
                table: "Factory");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Factory",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "JobOptionId",
                table: "Factory",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Company",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateTable(
                name: "Job",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TargetCount = table.Column<int>(type: "int", nullable: true),
                    TargetRunrate = table.Column<double>(type: "float", nullable: true),
                    TargetRuntime = table.Column<double>(type: "float", nullable: true),
                    ExpectedCycleTime = table.Column<double>(type: "float", nullable: true),
                    ExpectedCycleTimeDeviation = table.Column<double>(type: "float", nullable: true),
                    ClientKey = table.Column<string>(type: "nvarchar(191)", maxLength: 191, nullable: false),
                    Multiplier = table.Column<int>(type: "int", nullable: false),
                    IsTemplate = table.Column<bool>(type: "bit", nullable: false),
                    IsOpen = table.Column<bool>(type: "bit", nullable: false),
                    IsArchived = table.Column<bool>(type: "bit", nullable: false),
                    RuntimeScale = table.Column<int>(type: "int", nullable: false),
                    RunRateScale = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Job", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Factory_JobOptionId",
                table: "Factory",
                column: "JobOptionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Factory_Job_JobOptionId",
                table: "Factory",
                column: "JobOptionId",
                principalTable: "Job",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Factory_Job_JobOptionId",
                table: "Factory");

            migrationBuilder.DropTable(
                name: "Job");

            migrationBuilder.DropIndex(
                name: "IX_Factory_JobOptionId",
                table: "Factory");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Factory");

            migrationBuilder.DropColumn(
                name: "JobOptionId",
                table: "Factory");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Company");

            migrationBuilder.AddColumn<double>(
                name: "ExpectedCycleTime",
                table: "Factory",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "ExpectedCycleTimeDeviation",
                table: "Factory",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "TargetCount",
                table: "Factory",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "TargetRunRate",
                table: "Factory",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "TargetRunTime",
                table: "Factory",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
