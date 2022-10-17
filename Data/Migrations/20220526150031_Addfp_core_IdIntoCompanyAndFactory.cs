using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShiftWorx.Migrations
{
    public partial class Addfp_core_IdIntoCompanyAndFactory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "fp_core_Id",
                table: "Factory",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "fp_core_Id",
                table: "Company",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "fp_core_Id",
                table: "Factory");

            migrationBuilder.DropColumn(
                name: "fp_core_Id",
                table: "Company");
        }
    }
}
