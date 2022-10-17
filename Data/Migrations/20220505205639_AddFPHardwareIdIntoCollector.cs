using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShiftWorx.Migrations
{
    public partial class AddFPHardwareIdIntoCollector : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Collector_Machine_MachineId",
                table: "Collector");

            migrationBuilder.DropColumn(
                name: "RemoteAddress",
                table: "Collector");

            migrationBuilder.AlterColumn<int>(
                name: "MachineId",
                table: "Collector",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "FPHardwareId",
                table: "Collector",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Collector_Machine_MachineId",
                table: "Collector",
                column: "MachineId",
                principalTable: "Machine",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Collector_Machine_MachineId",
                table: "Collector");

            migrationBuilder.DropColumn(
                name: "FPHardwareId",
                table: "Collector");

            migrationBuilder.AlterColumn<int>(
                name: "MachineId",
                table: "Collector",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RemoteAddress",
                table: "Collector",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_Collector_Machine_MachineId",
                table: "Collector",
                column: "MachineId",
                principalTable: "Machine",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
