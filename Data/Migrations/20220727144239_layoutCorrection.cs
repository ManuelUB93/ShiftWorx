using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShiftWorx.Migrations
{
    public partial class layoutCorrection : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Panels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fpid = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PanelType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Width = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Height = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LayoutId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Panels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Panels_Layout_LayoutId",
                        column: x => x.LayoutId,
                        principalTable: "Layout",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Panels_LayoutId",
                table: "Panels",
                column: "LayoutId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Panels");
        }
    }
}
