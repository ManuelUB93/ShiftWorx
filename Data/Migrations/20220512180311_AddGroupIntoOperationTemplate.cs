using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShiftWorx.Migrations
{
    public partial class AddGroupIntoOperationTemplate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DeviceHub",
                table: "Machine");

            migrationBuilder.RenameColumn(
                name: "Line",
                table: "Machine",
                newName: "Group");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Group",
                table: "Machine",
                newName: "Line");

            migrationBuilder.AddColumn<string>(
                name: "DeviceHub",
                table: "Machine",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
