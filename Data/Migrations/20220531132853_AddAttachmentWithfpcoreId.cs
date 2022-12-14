using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShiftWorx.Migrations
{
    public partial class AddAttachmentWithfpcoreId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Attachment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AttachmentType = table.Column<int>(type: "int", nullable: false),
                    AttachedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DetachedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MachineId = table.Column<int>(type: "int", nullable: false),
                    CollectorId = table.Column<int>(type: "int", nullable: true),
                    CollecterName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AttachedOperationCodeId = table.Column<int>(type: "int", nullable: true),
                    AttachedJobId = table.Column<int>(type: "int", nullable: true),
                    fp_core_Id = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attachment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Attachment_Job_AttachedJobId",
                        column: x => x.AttachedJobId,
                        principalTable: "Job",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Attachment_Machine_MachineId",
                        column: x => x.MachineId,
                        principalTable: "Machine",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Attachment_StatusCode_AttachedOperationCodeId",
                        column: x => x.AttachedOperationCodeId,
                        principalTable: "StatusCode",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Attachment_AttachedJobId",
                table: "Attachment",
                column: "AttachedJobId");

            migrationBuilder.CreateIndex(
                name: "IX_Attachment_AttachedOperationCodeId",
                table: "Attachment",
                column: "AttachedOperationCodeId");

            migrationBuilder.CreateIndex(
                name: "IX_Attachment_MachineId",
                table: "Attachment",
                column: "MachineId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Attachment");
        }
    }
}
