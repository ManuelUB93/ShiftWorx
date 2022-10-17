using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShiftWorx.Migrations
{
    public partial class RenameOperationToStatus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Attachment_StatusCode_AttachedOperationCodeId",
                table: "Attachment");

            migrationBuilder.RenameColumn(
                name: "AttachedOperationCodeId",
                table: "Attachment",
                newName: "AttachedStatusCodeId");

            migrationBuilder.RenameIndex(
                name: "IX_Attachment_AttachedOperationCodeId",
                table: "Attachment",
                newName: "IX_Attachment_AttachedStatusCodeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Attachment_StatusCode_AttachedStatusCodeId",
                table: "Attachment",
                column: "AttachedStatusCodeId",
                principalTable: "StatusCode",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Attachment_StatusCode_AttachedStatusCodeId",
                table: "Attachment");

            migrationBuilder.RenameColumn(
                name: "AttachedStatusCodeId",
                table: "Attachment",
                newName: "AttachedOperationCodeId");

            migrationBuilder.RenameIndex(
                name: "IX_Attachment_AttachedStatusCodeId",
                table: "Attachment",
                newName: "IX_Attachment_AttachedOperationCodeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Attachment_StatusCode_AttachedOperationCodeId",
                table: "Attachment",
                column: "AttachedOperationCodeId",
                principalTable: "StatusCode",
                principalColumn: "Id");
        }
    }
}
