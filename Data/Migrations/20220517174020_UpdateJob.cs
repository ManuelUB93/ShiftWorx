using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShiftWorx.Migrations
{
    public partial class UpdateJob : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Factory_Job_JobInfoId",
                table: "Factory");

            migrationBuilder.DropIndex(
                name: "IX_Factory_JobInfoId",
                table: "Factory");

            migrationBuilder.DropColumn(
                name: "IsTemplate",
                table: "Job");

            migrationBuilder.DropColumn(
                name: "JobInfoId",
                table: "Factory");

            migrationBuilder.AlterColumn<int>(
                name: "Multiplier",
                table: "Job",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "ClientKey",
                table: "Job",
                type: "nvarchar(191)",
                maxLength: 191,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(191)",
                oldMaxLength: 191);

            migrationBuilder.AddColumn<string>(
                name: "CustomerName",
                table: "Job",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "EstmatedStartTime",
                table: "Job",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FactoryId",
                table: "Job",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Job_FactoryId",
                table: "Job",
                column: "FactoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Job_Factory_FactoryId",
                table: "Job",
                column: "FactoryId",
                principalTable: "Factory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Job_Factory_FactoryId",
                table: "Job");

            migrationBuilder.DropIndex(
                name: "IX_Job_FactoryId",
                table: "Job");

            migrationBuilder.DropColumn(
                name: "CustomerName",
                table: "Job");

            migrationBuilder.DropColumn(
                name: "EstmatedStartTime",
                table: "Job");

            migrationBuilder.DropColumn(
                name: "FactoryId",
                table: "Job");

            migrationBuilder.AlterColumn<int>(
                name: "Multiplier",
                table: "Job",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ClientKey",
                table: "Job",
                type: "nvarchar(191)",
                maxLength: 191,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(191)",
                oldMaxLength: 191,
                oldNullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsTemplate",
                table: "Job",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "JobInfoId",
                table: "Factory",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Factory_JobInfoId",
                table: "Factory",
                column: "JobInfoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Factory_Job_JobInfoId",
                table: "Factory",
                column: "JobInfoId",
                principalTable: "Job",
                principalColumn: "Id");
        }
    }
}
