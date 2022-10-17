using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShiftWorx.Migrations
{
    public partial class ReplaceCompanyWithFactoryInLayout : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Layout_Company_CompanyId",
                table: "Layout");

            migrationBuilder.DropIndex(
                name: "IX_Layout_CompanyId",
                table: "Layout");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "Layout");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CompanyId",
                table: "Layout",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Layout_CompanyId",
                table: "Layout",
                column: "CompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Layout_Company_CompanyId",
                table: "Layout",
                column: "CompanyId",
                principalTable: "Company",
                principalColumn: "Id");
        }
    }
}
