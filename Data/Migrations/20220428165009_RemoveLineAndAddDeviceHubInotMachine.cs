using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShiftWorx.Migrations
{
    public partial class RemoveLineAndAddDeviceHubInotMachine : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Company_Contact_ResellerId",
                table: "Company");

            migrationBuilder.DropForeignKey(
                name: "FK_Machine_Line_LineId",
                table: "Machine");

            migrationBuilder.DropTable(
                name: "Line");

            migrationBuilder.DropIndex(
                name: "IX_Machine_LineId",
                table: "Machine");

            migrationBuilder.DropIndex(
                name: "IX_Company_ResellerId",
                table: "Company");

            migrationBuilder.DropColumn(
                name: "LineId",
                table: "Machine");

            migrationBuilder.RenameColumn(
                name: "ResellerId",
                table: "Company",
                newName: "MinimumInactivityFilter");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Machine",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DeviceHub",
                table: "Machine",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "FactoryId",
                table: "Machine",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Line",
                table: "Machine",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "MaximumActivityModifier",
                table: "Factory",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MinimumActivityFilter",
                table: "Factory",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MinimumActivityModifier",
                table: "Factory",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MinimumInactivityFilter",
                table: "Factory",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Company",
                type: "nvarchar(75)",
                maxLength: 75,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256);

            migrationBuilder.AddColumn<string>(
                name: "FactoryKey",
                table: "Company",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Company",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "MaximumActivityModifier",
                table: "Company",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MinimumActivityFilter",
                table: "Company",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MinimumActivityModifier",
                table: "Company",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Machine_FactoryId",
                table: "Machine",
                column: "FactoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Machine_Factory_FactoryId",
                table: "Machine",
                column: "FactoryId",
                principalTable: "Factory",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Machine_Factory_FactoryId",
                table: "Machine");

            migrationBuilder.DropIndex(
                name: "IX_Machine_FactoryId",
                table: "Machine");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Machine");

            migrationBuilder.DropColumn(
                name: "DeviceHub",
                table: "Machine");

            migrationBuilder.DropColumn(
                name: "FactoryId",
                table: "Machine");

            migrationBuilder.DropColumn(
                name: "Line",
                table: "Machine");

            migrationBuilder.DropColumn(
                name: "MaximumActivityModifier",
                table: "Factory");

            migrationBuilder.DropColumn(
                name: "MinimumActivityFilter",
                table: "Factory");

            migrationBuilder.DropColumn(
                name: "MinimumActivityModifier",
                table: "Factory");

            migrationBuilder.DropColumn(
                name: "MinimumInactivityFilter",
                table: "Factory");

            migrationBuilder.DropColumn(
                name: "FactoryKey",
                table: "Company");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Company");

            migrationBuilder.DropColumn(
                name: "MaximumActivityModifier",
                table: "Company");

            migrationBuilder.DropColumn(
                name: "MinimumActivityFilter",
                table: "Company");

            migrationBuilder.DropColumn(
                name: "MinimumActivityModifier",
                table: "Company");

            migrationBuilder.RenameColumn(
                name: "MinimumInactivityFilter",
                table: "Company",
                newName: "ResellerId");

            migrationBuilder.AddColumn<int>(
                name: "LineId",
                table: "Machine",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Company",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(75)",
                oldMaxLength: 75);

            migrationBuilder.CreateTable(
                name: "Line",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FactoryId = table.Column<int>(type: "int", nullable: false),
                    Area = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Department = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Product = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Line", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Line_Factory_FactoryId",
                        column: x => x.FactoryId,
                        principalTable: "Factory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Machine_LineId",
                table: "Machine",
                column: "LineId");

            migrationBuilder.CreateIndex(
                name: "IX_Company_ResellerId",
                table: "Company",
                column: "ResellerId");

            migrationBuilder.CreateIndex(
                name: "IX_Line_FactoryId",
                table: "Line",
                column: "FactoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Company_Contact_ResellerId",
                table: "Company",
                column: "ResellerId",
                principalTable: "Contact",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Machine_Line_LineId",
                table: "Machine",
                column: "LineId",
                principalTable: "Line",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
