using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShiftWorx.Migrations
{
    public partial class RemoveKeyAttributesFromEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Collector_Machine_MachineId",
                table: "Collector");

            migrationBuilder.DropForeignKey(
                name: "FK_CollectorData_Collector_CollectorId",
                table: "CollectorData");

            migrationBuilder.DropForeignKey(
                name: "FK_Line_Factory_FactoryId",
                table: "Line");

            migrationBuilder.DropForeignKey(
                name: "FK_Machine_Line_LineId",
                table: "Machine");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Machine",
                table: "Machine");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Location",
                table: "Location");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Line",
                table: "Line");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Factory",
                table: "Factory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CollectorData",
                table: "CollectorData");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Collector",
                table: "Collector");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Machine");
            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Machine",
                type: "int",
                nullable: false)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Location");
            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Location",
                type: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Line");
            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Line",
                type: "int",
                nullable: false)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "Area",
                table: "Line",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Department",
                table: "Line",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Factory");
            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Factory",
                type: "int",
                nullable: false)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<double>(
                name: "ExpectedCycleTime",
                table: "Factory",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "ExpectedCycleTimeDeviation",
                table: "Factory",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "Language",
                table: "Factory",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Locale",
                table: "Factory",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "TargetCount",
                table: "Factory",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "TargetRunRate",
                table: "Factory",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "TargetRunTime",
                table: "Factory",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "TimeZone",
                table: "Factory",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "CollectorData");
            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "CollectorData",
                type: "int",
                nullable: false)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Collector");
            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Collector",
                type: "int",
                nullable: false)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Machine",
                table: "Machine",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Location",
                table: "Location",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Line",
                table: "Line",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Factory",
                table: "Factory",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CollectorData",
                table: "CollectorData",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Collector",
                table: "Collector",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Machine_LineId",
                table: "Machine",
                column: "LineId");

            migrationBuilder.CreateIndex(
                name: "IX_Location_CompanyId",
                table: "Location",
                column: "CompanyId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Line_FactoryId",
                table: "Line",
                column: "FactoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Factory_CompanyId",
                table: "Factory",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_CollectorData_CollectorId",
                table: "CollectorData",
                column: "CollectorId");

            migrationBuilder.CreateIndex(
                name: "IX_Collector_MachineId",
                table: "Collector",
                column: "MachineId");

            migrationBuilder.AddForeignKey(
                name: "FK_Collector_Machine_MachineId",
                table: "Collector",
                column: "MachineId",
                principalTable: "Machine",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CollectorData_Collector_CollectorId",
                table: "CollectorData",
                column: "CollectorId",
                principalTable: "Collector",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Line_Factory_FactoryId",
                table: "Line",
                column: "FactoryId",
                principalTable: "Factory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Machine_Line_LineId",
                table: "Machine",
                column: "LineId",
                principalTable: "Line",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Collector_Machine_MachineId",
                table: "Collector");

            migrationBuilder.DropForeignKey(
                name: "FK_CollectorData_Collector_CollectorId",
                table: "CollectorData");

            migrationBuilder.DropForeignKey(
                name: "FK_Line_Factory_FactoryId",
                table: "Line");

            migrationBuilder.DropForeignKey(
                name: "FK_Machine_Line_LineId",
                table: "Machine");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Machine",
                table: "Machine");

            migrationBuilder.DropIndex(
                name: "IX_Machine_LineId",
                table: "Machine");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Location",
                table: "Location");

            migrationBuilder.DropIndex(
                name: "IX_Location_CompanyId",
                table: "Location");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Line",
                table: "Line");

            migrationBuilder.DropIndex(
                name: "IX_Line_FactoryId",
                table: "Line");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Factory",
                table: "Factory");

            migrationBuilder.DropIndex(
                name: "IX_Factory_CompanyId",
                table: "Factory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CollectorData",
                table: "CollectorData");

            migrationBuilder.DropIndex(
                name: "IX_CollectorData_CollectorId",
                table: "CollectorData");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Collector",
                table: "Collector");

            migrationBuilder.DropIndex(
                name: "IX_Collector_MachineId",
                table: "Collector");

            migrationBuilder.DropColumn(
                name: "Area",
                table: "Line");

            migrationBuilder.DropColumn(
                name: "Department",
                table: "Line");

            migrationBuilder.DropColumn(
                name: "ExpectedCycleTime",
                table: "Factory");

            migrationBuilder.DropColumn(
                name: "ExpectedCycleTimeDeviation",
                table: "Factory");

            migrationBuilder.DropColumn(
                name: "Language",
                table: "Factory");

            migrationBuilder.DropColumn(
                name: "Locale",
                table: "Factory");

            migrationBuilder.DropColumn(
                name: "TargetCount",
                table: "Factory");

            migrationBuilder.DropColumn(
                name: "TargetRunRate",
                table: "Factory");

            migrationBuilder.DropColumn(
                name: "TargetRunTime",
                table: "Factory");

            migrationBuilder.DropColumn(
                name: "TimeZone",
                table: "Factory");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Machine",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Location",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Line",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Factory",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "CollectorData",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Collector",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Machine",
                table: "Machine",
                column: "LineId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Location",
                table: "Location",
                column: "CompanyId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Line",
                table: "Line",
                column: "FactoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Factory",
                table: "Factory",
                column: "CompanyId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CollectorData",
                table: "CollectorData",
                column: "CollectorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Collector",
                table: "Collector",
                column: "MachineId");

            migrationBuilder.AddForeignKey(
                name: "FK_Collector_Machine_MachineId",
                table: "Collector",
                column: "MachineId",
                principalTable: "Machine",
                principalColumn: "LineId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CollectorData_Collector_CollectorId",
                table: "CollectorData",
                column: "CollectorId",
                principalTable: "Collector",
                principalColumn: "MachineId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Line_Factory_FactoryId",
                table: "Line",
                column: "FactoryId",
                principalTable: "Factory",
                principalColumn: "CompanyId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Machine_Line_LineId",
                table: "Machine",
                column: "LineId",
                principalTable: "Line",
                principalColumn: "FactoryId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
