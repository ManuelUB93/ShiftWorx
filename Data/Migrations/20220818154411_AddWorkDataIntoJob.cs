using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShiftWorx.Migrations
{
    public partial class AddWorkDataIntoJob : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsArchived",
                table: "Operation");

            migrationBuilder.DropColumn(
                name: "IsArchived",
                table: "Job");

            migrationBuilder.AddColumn<DateTime>(
                name: "EstmatedStartDate",
                table: "OperationTemplate",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "ExpectedCycleTime",
                table: "OperationTemplate",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "ExpectedCycleTimeDeviation",
                table: "OperationTemplate",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Multiplier",
                table: "OperationTemplate",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "PlannedEndDate",
                table: "OperationTemplate",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RunRateScale",
                table: "OperationTemplate",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RuntimeScale",
                table: "OperationTemplate",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TargetCount",
                table: "OperationTemplate",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "TargetRunrate",
                table: "OperationTemplate",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "TargetRuntime",
                table: "OperationTemplate",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CustomerName",
                table: "JobTemplate",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "EstmatedStartDate",
                table: "JobTemplate",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "ExpectedCycleTime",
                table: "JobTemplate",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "ExpectedCycleTimeDeviation",
                table: "JobTemplate",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsOpen",
                table: "JobTemplate",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "Multiplier",
                table: "JobTemplate",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "PlannedEndDate",
                table: "JobTemplate",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RunRateScale",
                table: "JobTemplate",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RuntimeScale",
                table: "JobTemplate",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TargetCount",
                table: "JobTemplate",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "TargetRunrate",
                table: "JobTemplate",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "TargetRuntime",
                table: "JobTemplate",
                type: "float",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EstmatedStartDate",
                table: "OperationTemplate");

            migrationBuilder.DropColumn(
                name: "ExpectedCycleTime",
                table: "OperationTemplate");

            migrationBuilder.DropColumn(
                name: "ExpectedCycleTimeDeviation",
                table: "OperationTemplate");

            migrationBuilder.DropColumn(
                name: "Multiplier",
                table: "OperationTemplate");

            migrationBuilder.DropColumn(
                name: "PlannedEndDate",
                table: "OperationTemplate");

            migrationBuilder.DropColumn(
                name: "RunRateScale",
                table: "OperationTemplate");

            migrationBuilder.DropColumn(
                name: "RuntimeScale",
                table: "OperationTemplate");

            migrationBuilder.DropColumn(
                name: "TargetCount",
                table: "OperationTemplate");

            migrationBuilder.DropColumn(
                name: "TargetRunrate",
                table: "OperationTemplate");

            migrationBuilder.DropColumn(
                name: "TargetRuntime",
                table: "OperationTemplate");

            migrationBuilder.DropColumn(
                name: "CustomerName",
                table: "JobTemplate");

            migrationBuilder.DropColumn(
                name: "EstmatedStartDate",
                table: "JobTemplate");

            migrationBuilder.DropColumn(
                name: "ExpectedCycleTime",
                table: "JobTemplate");

            migrationBuilder.DropColumn(
                name: "ExpectedCycleTimeDeviation",
                table: "JobTemplate");

            migrationBuilder.DropColumn(
                name: "IsOpen",
                table: "JobTemplate");

            migrationBuilder.DropColumn(
                name: "Multiplier",
                table: "JobTemplate");

            migrationBuilder.DropColumn(
                name: "PlannedEndDate",
                table: "JobTemplate");

            migrationBuilder.DropColumn(
                name: "RunRateScale",
                table: "JobTemplate");

            migrationBuilder.DropColumn(
                name: "RuntimeScale",
                table: "JobTemplate");

            migrationBuilder.DropColumn(
                name: "TargetCount",
                table: "JobTemplate");

            migrationBuilder.DropColumn(
                name: "TargetRunrate",
                table: "JobTemplate");

            migrationBuilder.DropColumn(
                name: "TargetRuntime",
                table: "JobTemplate");

            migrationBuilder.AddColumn<bool>(
                name: "IsArchived",
                table: "Operation",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsArchived",
                table: "Job",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
