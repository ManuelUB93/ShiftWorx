using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShiftWorx.Migrations
{
    public partial class AddAttachment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OperationCategory_Factory_FactoryId",
                table: "OperationCategory");

            migrationBuilder.AlterColumn<string>(
                name: "Group",
                table: "OperationCategory",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "FactoryId",
                table: "OperationCategory",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "JobAttachment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JobId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AttachmentType = table.Column<int>(type: "int", nullable: false),
                    AttachedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DetachedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MachineId = table.Column<int>(type: "int", nullable: false),
                    CollectorId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobAttachment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JobAttachment_Collector_CollectorId",
                        column: x => x.CollectorId,
                        principalTable: "Collector",
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
                });

            migrationBuilder.CreateTable(
                name: "OperationCodeAttachment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OperationCodeId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AttachmentType = table.Column<int>(type: "int", nullable: false),
                    AttachedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DetachedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MachineId = table.Column<int>(type: "int", nullable: false),
                    CollectorId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperationCodeAttachment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OperationCodeAttachment_Collector_CollectorId",
                        column: x => x.CollectorId,
                        principalTable: "Collector",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_OperationCodeAttachment_Machine_MachineId",
                        column: x => x.MachineId,
                        principalTable: "Machine",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OperationCodeAttachment_OperationCode_OperationCodeId",
                        column: x => x.OperationCodeId,
                        principalTable: "OperationCode",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_JobAttachment_CollectorId",
                table: "JobAttachment",
                column: "CollectorId");

            migrationBuilder.CreateIndex(
                name: "IX_JobAttachment_JobId",
                table: "JobAttachment",
                column: "JobId");

            migrationBuilder.CreateIndex(
                name: "IX_JobAttachment_MachineId",
                table: "JobAttachment",
                column: "MachineId");

            migrationBuilder.CreateIndex(
                name: "IX_OperationCodeAttachment_CollectorId",
                table: "OperationCodeAttachment",
                column: "CollectorId");

            migrationBuilder.CreateIndex(
                name: "IX_OperationCodeAttachment_MachineId",
                table: "OperationCodeAttachment",
                column: "MachineId");

            migrationBuilder.CreateIndex(
                name: "IX_OperationCodeAttachment_OperationCodeId",
                table: "OperationCodeAttachment",
                column: "OperationCodeId");

            migrationBuilder.AddForeignKey(
                name: "FK_OperationCategory_Factory_FactoryId",
                table: "OperationCategory",
                column: "FactoryId",
                principalTable: "Factory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OperationCategory_Factory_FactoryId",
                table: "OperationCategory");

            migrationBuilder.DropTable(
                name: "JobAttachment");

            migrationBuilder.DropTable(
                name: "OperationCodeAttachment");

            migrationBuilder.AlterColumn<string>(
                name: "Group",
                table: "OperationCategory",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "FactoryId",
                table: "OperationCategory",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_OperationCategory_Factory_FactoryId",
                table: "OperationCategory",
                column: "FactoryId",
                principalTable: "Factory",
                principalColumn: "Id");
        }
    }
}
