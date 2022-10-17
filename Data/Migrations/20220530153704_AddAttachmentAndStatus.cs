using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShiftWorx.Migrations
{
    public partial class AddAttachmentAndStatus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "fp_data_source_Id",
                table: "Machine",
                newName: "fp_core_Id");

            migrationBuilder.CreateTable(
                name: "StatusCategory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Group = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FactoryId = table.Column<int>(type: "int", nullable: false),
                    fp_core_Id = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatusCategory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StatusCategory_Factory_FactoryId",
                        column: x => x.FactoryId,
                        principalTable: "Factory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StatusCode",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    fp_core_Id = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatusCode", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StatusCode_StatusCategory_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "StatusCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_StatusCategory_FactoryId",
                table: "StatusCategory",
                column: "FactoryId");

            migrationBuilder.CreateIndex(
                name: "IX_StatusCode_CategoryId",
                table: "StatusCode",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Attachment");

            migrationBuilder.DropTable(
                name: "StatusCode");

            migrationBuilder.DropTable(
                name: "StatusCategory");

            migrationBuilder.RenameColumn(
                name: "fp_core_Id",
                table: "Machine",
                newName: "fp_data_source_Id");
        }
    }
}
