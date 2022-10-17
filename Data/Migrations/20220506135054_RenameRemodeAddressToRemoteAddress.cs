using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShiftWorx.Migrations
{
    public partial class RenameRemodeAddressToRemoteAddress : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "RemodeAddress",
                table: "Machine",
                newName: "RemoteAddress");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "RemoteAddress",
                table: "Machine",
                newName: "RemodeAddress");
        }
    }
}
