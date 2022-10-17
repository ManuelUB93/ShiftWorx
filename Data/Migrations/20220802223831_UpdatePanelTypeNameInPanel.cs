using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShiftWorx.Migrations
{
    public partial class UpdatePanelTypeNameInPanel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Panel_PanelType_PanelTypeId",
                table: "Panel");

            migrationBuilder.AlterColumn<int>(
                name: "PanelTypeId",
                table: "Panel",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Panel_PanelType_PanelTypeId",
                table: "Panel",
                column: "PanelTypeId",
                principalTable: "PanelType",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Panel_PanelType_PanelTypeId",
                table: "Panel");

            migrationBuilder.AlterColumn<int>(
                name: "PanelTypeId",
                table: "Panel",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Panel_PanelType_PanelTypeId",
                table: "Panel",
                column: "PanelTypeId",
                principalTable: "PanelType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
