using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShiftWorx.Migrations
{
    public partial class RenameOperationCodeToStatusCode : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JobAttachment_Collector_CollectorId",
                table: "JobAttachment");

            migrationBuilder.DropForeignKey(
                name: "FK_OperationCodeAttachment_Collector_CollectorId",
                table: "OperationCodeAttachment");

            migrationBuilder.DropIndex(
                name: "IX_OperationCodeAttachment_CollectorId",
                table: "OperationCodeAttachment");

            migrationBuilder.DropIndex(
                name: "IX_JobAttachment_CollectorId",
                table: "JobAttachment");

            migrationBuilder.AddColumn<int>(
                name: "AttachedJobId",
                table: "OperationCodeAttachment",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AttachedOperationCodeId",
                table: "OperationCodeAttachment",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CollecterName",
                table: "OperationCodeAttachment",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "fp_core_Id",
                table: "Operation",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "AttachedJobId",
                table: "JobAttachment",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AttachedOperationCodeId",
                table: "JobAttachment",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CollecterName",
                table: "JobAttachment",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "fp_core_Id",
                table: "Job",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_OperationCodeAttachment_AttachedJobId",
                table: "OperationCodeAttachment",
                column: "AttachedJobId");

            migrationBuilder.CreateIndex(
                name: "IX_OperationCodeAttachment_AttachedOperationCodeId",
                table: "OperationCodeAttachment",
                column: "AttachedOperationCodeId");

            migrationBuilder.CreateIndex(
                name: "IX_JobAttachment_AttachedJobId",
                table: "JobAttachment",
                column: "AttachedJobId");

            migrationBuilder.CreateIndex(
                name: "IX_JobAttachment_AttachedOperationCodeId",
                table: "JobAttachment",
                column: "AttachedOperationCodeId");

            migrationBuilder.AddForeignKey(
                name: "FK_JobAttachment_Job_AttachedJobId",
                table: "JobAttachment",
                column: "AttachedJobId",
                principalTable: "Job",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_JobAttachment_OperationCode_AttachedOperationCodeId",
                table: "JobAttachment",
                column: "AttachedOperationCodeId",
                principalTable: "OperationCode",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OperationCodeAttachment_Job_AttachedJobId",
                table: "OperationCodeAttachment",
                column: "AttachedJobId",
                principalTable: "Job",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OperationCodeAttachment_OperationCode_AttachedOperationCodeId",
                table: "OperationCodeAttachment",
                column: "AttachedOperationCodeId",
                principalTable: "OperationCode",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JobAttachment_Job_AttachedJobId",
                table: "JobAttachment");

            migrationBuilder.DropForeignKey(
                name: "FK_JobAttachment_OperationCode_AttachedOperationCodeId",
                table: "JobAttachment");

            migrationBuilder.DropForeignKey(
                name: "FK_OperationCodeAttachment_Job_AttachedJobId",
                table: "OperationCodeAttachment");

            migrationBuilder.DropForeignKey(
                name: "FK_OperationCodeAttachment_OperationCode_AttachedOperationCodeId",
                table: "OperationCodeAttachment");

            migrationBuilder.DropIndex(
                name: "IX_OperationCodeAttachment_AttachedJobId",
                table: "OperationCodeAttachment");

            migrationBuilder.DropIndex(
                name: "IX_OperationCodeAttachment_AttachedOperationCodeId",
                table: "OperationCodeAttachment");

            migrationBuilder.DropIndex(
                name: "IX_JobAttachment_AttachedJobId",
                table: "JobAttachment");

            migrationBuilder.DropIndex(
                name: "IX_JobAttachment_AttachedOperationCodeId",
                table: "JobAttachment");

            migrationBuilder.DropColumn(
                name: "AttachedJobId",
                table: "OperationCodeAttachment");

            migrationBuilder.DropColumn(
                name: "AttachedOperationCodeId",
                table: "OperationCodeAttachment");

            migrationBuilder.DropColumn(
                name: "CollecterName",
                table: "OperationCodeAttachment");

            migrationBuilder.DropColumn(
                name: "AttachedJobId",
                table: "JobAttachment");

            migrationBuilder.DropColumn(
                name: "AttachedOperationCodeId",
                table: "JobAttachment");

            migrationBuilder.DropColumn(
                name: "CollecterName",
                table: "JobAttachment");

            migrationBuilder.AlterColumn<int>(
                name: "fp_core_Id",
                table: "Operation",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "fp_core_Id",
                table: "Job",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_OperationCodeAttachment_CollectorId",
                table: "OperationCodeAttachment",
                column: "CollectorId");

            migrationBuilder.CreateIndex(
                name: "IX_JobAttachment_CollectorId",
                table: "JobAttachment",
                column: "CollectorId");

            migrationBuilder.AddForeignKey(
                name: "FK_JobAttachment_Collector_CollectorId",
                table: "JobAttachment",
                column: "CollectorId",
                principalTable: "Collector",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OperationCodeAttachment_Collector_CollectorId",
                table: "OperationCodeAttachment",
                column: "CollectorId",
                principalTable: "Collector",
                principalColumn: "Id");
        }
    }
}
