using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShiftWorx.Migrations
{
    public partial class RemoveOperationCodeAndCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "JobAttachment");

            migrationBuilder.DropTable(
                name: "OperationCodeAttachment");

            migrationBuilder.DropTable(
                name: "OperationCode");

            migrationBuilder.DropTable(
                name: "OperationCategory");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StatusCategory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FactoryId = table.Column<int>(type: "int", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Group = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    fp_core_Id = table.Column<int>(type: "int", nullable: true)
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
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    fp_core_Id = table.Column<int>(type: "int", nullable: true)
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
                name: "JobAttachment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AttachedJobId = table.Column<int>(type: "int", nullable: true),
                    AttachedOperationCodeId = table.Column<int>(type: "int", nullable: true),
                    JobId = table.Column<int>(type: "int", nullable: false),
                    MachineId = table.Column<int>(type: "int", nullable: false),
                    AttachedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AttachmentType = table.Column<int>(type: "int", nullable: false),
                    CollecterName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CollectorId = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DetachedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobAttachment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JobAttachment_Job_AttachedJobId",
                        column: x => x.AttachedJobId,
                        principalTable: "Job",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_JobAttachment_Job_JobId",
                        column: x => x.JobId,
                        principalTable: "Job",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JobAttachment_Machine_MachineId",
                        column: x => x.MachineId,
                        principalTable: "Machine",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JobAttachment_StatusCode_AttachedOperationCodeId",
                        column: x => x.AttachedOperationCodeId,
                        principalTable: "StatusCode",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "OperationCodeAttachment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AttachedJobId = table.Column<int>(type: "int", nullable: true),
                    AttachedOperationCodeId = table.Column<int>(type: "int", nullable: true),
                    MachineId = table.Column<int>(type: "int", nullable: false),
                    OperationCodeId = table.Column<int>(type: "int", nullable: false),
                    AttachedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AttachmentType = table.Column<int>(type: "int", nullable: false),
                    CollecterName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CollectorId = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DetachedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperationCodeAttachment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OperationCodeAttachment_Job_AttachedJobId",
                        column: x => x.AttachedJobId,
                        principalTable: "Job",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_OperationCodeAttachment_Machine_MachineId",
                        column: x => x.MachineId,
                        principalTable: "Machine",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OperationCodeAttachment_StatusCode_AttachedOperationCodeId",
                        column: x => x.AttachedOperationCodeId,
                        principalTable: "StatusCode",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_OperationCodeAttachment_StatusCode_OperationCodeId",
                        column: x => x.OperationCodeId,
                        principalTable: "StatusCode",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_JobAttachment_AttachedJobId",
                table: "JobAttachment",
                column: "AttachedJobId");

            migrationBuilder.CreateIndex(
                name: "IX_JobAttachment_AttachedOperationCodeId",
                table: "JobAttachment",
                column: "AttachedOperationCodeId");

            migrationBuilder.CreateIndex(
                name: "IX_JobAttachment_JobId",
                table: "JobAttachment",
                column: "JobId");

            migrationBuilder.CreateIndex(
                name: "IX_JobAttachment_MachineId",
                table: "JobAttachment",
                column: "MachineId");

            migrationBuilder.CreateIndex(
                name: "IX_OperationCodeAttachment_AttachedJobId",
                table: "OperationCodeAttachment",
                column: "AttachedJobId");

            migrationBuilder.CreateIndex(
                name: "IX_OperationCodeAttachment_AttachedOperationCodeId",
                table: "OperationCodeAttachment",
                column: "AttachedOperationCodeId");

            migrationBuilder.CreateIndex(
                name: "IX_OperationCodeAttachment_MachineId",
                table: "OperationCodeAttachment",
                column: "MachineId");

            migrationBuilder.CreateIndex(
                name: "IX_OperationCodeAttachment_OperationCodeId",
                table: "OperationCodeAttachment",
                column: "OperationCodeId");

            migrationBuilder.CreateIndex(
                name: "IX_StatusCategory_FactoryId",
                table: "StatusCategory",
                column: "FactoryId");

            migrationBuilder.CreateIndex(
                name: "IX_StatusCode_CategoryId",
                table: "StatusCode",
                column: "CategoryId");
        }
    }
}
