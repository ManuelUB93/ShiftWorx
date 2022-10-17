using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShiftWorx.Migrations
{
    public partial class AddLayoutAndPanel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CompanyId",
                table: "Layout",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Layout",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "Layout",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FreePointProductId",
                table: "Layout",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsReporting",
                table: "Layout",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Layout",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "Layout",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "fp_core_id",
                table: "Layout",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "FreePointProduct",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Alias = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Hide = table.Column<bool>(type: "bit", nullable: false),
                    fp_core_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FreePointProduct", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PanelPreviewInfo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PanelTypeKey = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PanelTier = table.Column<int>(type: "int", nullable: false),
                    PreviewImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fp_core_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PanelPreviewInfo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PanelType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Key = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category = table.Column<int>(type: "int", nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MetaData = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VersionMajor = table.Column<int>(type: "int", nullable: false),
                    VersionMinor = table.Column<int>(type: "int", nullable: false),
                    GlobalAccess = table.Column<bool>(type: "bit", nullable: false),
                    fp_core_id = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PanelType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Panel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LayoutId = table.Column<int>(type: "int", nullable: false),
                    PanelTypeId = table.Column<int>(type: "int", nullable: false),
                    Placement = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Config = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fp_core_id = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Panel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Panel_Layout_LayoutId",
                        column: x => x.LayoutId,
                        principalTable: "Layout",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Panel_PanelType_PanelTypeId",
                        column: x => x.PanelTypeId,
                        principalTable: "PanelType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Layout_CompanyId",
                table: "Layout",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Layout_FreePointProductId",
                table: "Layout",
                column: "FreePointProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Panel_LayoutId",
                table: "Panel",
                column: "LayoutId");

            migrationBuilder.CreateIndex(
                name: "IX_Panel_PanelTypeId",
                table: "Panel",
                column: "PanelTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Layout_Company_CompanyId",
                table: "Layout",
                column: "CompanyId",
                principalTable: "Company",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Layout_FreePointProduct_FreePointProductId",
                table: "Layout",
                column: "FreePointProductId",
                principalTable: "FreePointProduct",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Layout_Company_CompanyId",
                table: "Layout");

            migrationBuilder.DropForeignKey(
                name: "FK_Layout_FreePointProduct_FreePointProductId",
                table: "Layout");

            migrationBuilder.DropTable(
                name: "FreePointProduct");

            migrationBuilder.DropTable(
                name: "Panel");

            migrationBuilder.DropTable(
                name: "PanelPreviewInfo");

            migrationBuilder.DropTable(
                name: "PanelType");

            migrationBuilder.DropIndex(
                name: "IX_Layout_CompanyId",
                table: "Layout");

            migrationBuilder.DropIndex(
                name: "IX_Layout_FreePointProductId",
                table: "Layout");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "Layout");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Layout");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "Layout");

            migrationBuilder.DropColumn(
                name: "FreePointProductId",
                table: "Layout");

            migrationBuilder.DropColumn(
                name: "IsReporting",
                table: "Layout");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Layout");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "Layout");

            migrationBuilder.DropColumn(
                name: "fp_core_id",
                table: "Layout");
        }
    }
}
