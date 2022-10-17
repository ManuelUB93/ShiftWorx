using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShiftWorx.Migrations
{
    public partial class RemoveLocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Location_CompanyId",
                table: "Location");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Line",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "Line",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Line",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "Job",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Job",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Factory",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "Factory",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "Factory",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Factory",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FactoryKey",
                table: "Factory",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Factory",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Latitude",
                table: "Factory",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Longitude",
                table: "Factory",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PostalCode",
                table: "Factory",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Province",
                table: "Factory",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Street",
                table: "Factory",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Factory",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Company",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "Company",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "Company",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Company",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Latitude",
                table: "Company",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Longitude",
                table: "Company",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PostalCode",
                table: "Company",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Province",
                table: "Company",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Street",
                table: "Company",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Company",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "CollectorData",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "CollectorData",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "CollectorData",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Collector",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "Collector",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Collector",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Collector",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateIndex(
                name: "IX_Location_CompanyId",
                table: "Location",
                column: "CompanyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Location_CompanyId",
                table: "Location");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Line");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "Line");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Line");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "Job");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Job");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Factory");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "Factory");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "Factory");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Factory");

            migrationBuilder.DropColumn(
                name: "FactoryKey",
                table: "Factory");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Factory");

            migrationBuilder.DropColumn(
                name: "Latitude",
                table: "Factory");

            migrationBuilder.DropColumn(
                name: "Longitude",
                table: "Factory");

            migrationBuilder.DropColumn(
                name: "PostalCode",
                table: "Factory");

            migrationBuilder.DropColumn(
                name: "Province",
                table: "Factory");

            migrationBuilder.DropColumn(
                name: "Street",
                table: "Factory");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Factory");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Company");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "Company");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "Company");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Company");

            migrationBuilder.DropColumn(
                name: "Latitude",
                table: "Company");

            migrationBuilder.DropColumn(
                name: "Longitude",
                table: "Company");

            migrationBuilder.DropColumn(
                name: "PostalCode",
                table: "Company");

            migrationBuilder.DropColumn(
                name: "Province",
                table: "Company");

            migrationBuilder.DropColumn(
                name: "Street",
                table: "Company");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Company");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "CollectorData");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "CollectorData");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "CollectorData");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Collector");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "Collector");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Collector");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Collector");

            migrationBuilder.CreateIndex(
                name: "IX_Location_CompanyId",
                table: "Location",
                column: "CompanyId",
                unique: true);
        }
    }
}
