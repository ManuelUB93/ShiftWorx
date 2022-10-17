using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShiftWorx.Migrations
{
    public partial class AddResellerIntoCompany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ResellerId",
                table: "Company",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Company_ResellerId",
                table: "Company",
                column: "ResellerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Company_Contact_ResellerId",
                table: "Company",
                column: "ResellerId",
                principalTable: "Contact",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Company_Contact_ResellerId",
                table: "Company");

            migrationBuilder.DropIndex(
                name: "IX_Company_ResellerId",
                table: "Company");

            migrationBuilder.DropColumn(
                name: "ResellerId",
                table: "Company");
        }
    }
}
