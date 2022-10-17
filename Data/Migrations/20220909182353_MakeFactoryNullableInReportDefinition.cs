using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShiftWorx.Migrations
{
    public partial class MakeFactoryNullableInReportDefinition : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ReportDefinition_Factory_FactoryId",
                table: "ReportDefinition");

            migrationBuilder.DropForeignKey(
                name: "FK_ReportDefinition_ReportSubType_ReportSubTypeId",
                table: "ReportDefinition");

            migrationBuilder.AlterColumn<int>(
                name: "ReportSubTypeId",
                table: "ReportDefinition",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "FactoryId",
                table: "ReportDefinition",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_ReportDefinition_Factory_FactoryId",
                table: "ReportDefinition",
                column: "FactoryId",
                principalTable: "Factory",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ReportDefinition_ReportSubType_ReportSubTypeId",
                table: "ReportDefinition",
                column: "ReportSubTypeId",
                principalTable: "ReportSubType",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ReportDefinition_Factory_FactoryId",
                table: "ReportDefinition");

            migrationBuilder.DropForeignKey(
                name: "FK_ReportDefinition_ReportSubType_ReportSubTypeId",
                table: "ReportDefinition");

            migrationBuilder.AlterColumn<int>(
                name: "ReportSubTypeId",
                table: "ReportDefinition",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "FactoryId",
                table: "ReportDefinition",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ReportDefinition_Factory_FactoryId",
                table: "ReportDefinition",
                column: "FactoryId",
                principalTable: "Factory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ReportDefinition_ReportSubType_ReportSubTypeId",
                table: "ReportDefinition",
                column: "ReportSubTypeId",
                principalTable: "ReportSubType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
