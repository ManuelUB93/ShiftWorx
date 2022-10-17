using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShiftWorx.Migrations
{
    public partial class AddPlanEndDateIntoOperation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EstmatedStartTime",
                table: "Operation",
                newName: "EstmatedStartDate");

            migrationBuilder.RenameColumn(
                name: "EstmatedStartTime",
                table: "Job",
                newName: "EstmatedStartDate");

            migrationBuilder.AddColumn<DateTime>(
                name: "PlannedEndDate",
                table: "Operation",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "PlannedEndDate",
                table: "Job",
                type: "datetime2",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PlannedEndDate",
                table: "Operation");

            migrationBuilder.DropColumn(
                name: "PlannedEndDate",
                table: "Job");

            migrationBuilder.RenameColumn(
                name: "EstmatedStartDate",
                table: "Operation",
                newName: "EstmatedStartTime");

            migrationBuilder.RenameColumn(
                name: "EstmatedStartDate",
                table: "Job",
                newName: "EstmatedStartTime");
        }
    }
}
