using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShiftWorx.Migrations
{
    public partial class AddCustomerNameIntoJob : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "JobTemplateId",
                table: "Job",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "fp_core_Id",
                table: "Job",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "JobTemplateId",
                table: "Job");

            migrationBuilder.DropColumn(
                name: "fp_core_Id",
                table: "Job");
        }
    }
}
