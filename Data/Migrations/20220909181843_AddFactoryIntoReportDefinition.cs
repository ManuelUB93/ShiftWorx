using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShiftWorx.Migrations
{
    public partial class AddFactoryIntoReportDefinition : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ReportDefinition_Company_CompanyId",
                table: "ReportDefinition");

            migrationBuilder.RenameColumn(
                name: "CompanyId",
                table: "ReportDefinition",
                newName: "FactoryId");

            migrationBuilder.RenameIndex(
                name: "IX_ReportDefinition_CompanyId",
                table: "ReportDefinition",
                newName: "IX_ReportDefinition_FactoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_ReportDefinition_Factory_FactoryId",
                table: "ReportDefinition",
                column: "FactoryId",
                principalTable: "Factory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ReportDefinition_Factory_FactoryId",
                table: "ReportDefinition");

            migrationBuilder.RenameColumn(
                name: "FactoryId",
                table: "ReportDefinition",
                newName: "CompanyId");

            migrationBuilder.RenameIndex(
                name: "IX_ReportDefinition_FactoryId",
                table: "ReportDefinition",
                newName: "IX_ReportDefinition_CompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_ReportDefinition_Company_CompanyId",
                table: "ReportDefinition",
                column: "CompanyId",
                principalTable: "Company",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
