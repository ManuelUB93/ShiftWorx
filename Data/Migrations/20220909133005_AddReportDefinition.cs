using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShiftWorx.Migrations
{
    public partial class AddReportDefinition : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ReportSubType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Key = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DisplayName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DisplayOrder = table.Column<int>(type: "int", nullable: false),
                    fp_core_id = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReportSubType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ReportDefinition",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Suffix = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StaticResult = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Divisor = table.Column<int>(type: "int", nullable: true),
                    TickRate = table.Column<int>(type: "int", nullable: true),
                    ScrapAdjust = table.Column<bool>(type: "bit", nullable: false),
                    ShiftBased = table.Column<bool>(type: "bit", nullable: false),
                    ActiveShiftBased = table.Column<bool>(type: "bit", nullable: false),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TimeStepSeconds = table.Column<int>(type: "int", nullable: true),
                    Offset = table.Column<int>(type: "int", nullable: true),
                    WindowSizeSeconds = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    ReportSubTypeId = table.Column<int>(type: "int", nullable: false),
                    ReportType = table.Column<int>(type: "int", nullable: false),
                    ChartType = table.Column<int>(type: "int", nullable: false),
                    CalculationWindowTransitionType = table.Column<int>(type: "int", nullable: false),
                    TickRateType = table.Column<int>(type: "int", nullable: false),
                    MathType = table.Column<int>(type: "int", nullable: false),
                    ValueType = table.Column<int>(type: "int", nullable: false),
                    ReportRangeType = table.Column<int>(type: "int", nullable: false),
                    RollingCalculationWindow = table.Column<int>(type: "int", nullable: false),
                    SemiFixedCalculationWindow = table.Column<int>(type: "int", nullable: false),
                    SemiFixedCalculationWindowOffset = table.Column<int>(type: "int", nullable: false),
                    fp_core_id = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReportDefinition", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReportDefinition_Company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReportDefinition_ReportSubType_ReportSubTypeId",
                        column: x => x.ReportSubTypeId,
                        principalTable: "ReportSubType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ReportDefinitionCollector",
                columns: table => new
                {
                    ReportDefinitionId = table.Column<int>(type: "int", nullable: false),
                    CollectorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReportDefinitionCollector", x => new { x.ReportDefinitionId, x.CollectorId });
                    table.ForeignKey(
                        name: "FK_ReportDefinitionCollector_Collector_CollectorId",
                        column: x => x.CollectorId,
                        principalTable: "Collector",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReportDefinitionCollector_ReportDefinition_ReportDefinitionId",
                        column: x => x.ReportDefinitionId,
                        principalTable: "ReportDefinition",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ReportDefinitionJob",
                columns: table => new
                {
                    ReportDefinitionId = table.Column<int>(type: "int", nullable: false),
                    JobId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReportDefinitionJob", x => new { x.ReportDefinitionId, x.JobId });
                    table.ForeignKey(
                        name: "FK_ReportDefinitionJob_Job_JobId",
                        column: x => x.JobId,
                        principalTable: "Job",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReportDefinitionJob_ReportDefinition_ReportDefinitionId",
                        column: x => x.ReportDefinitionId,
                        principalTable: "ReportDefinition",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ReportDefinitionMachine",
                columns: table => new
                {
                    ReportDefinitionId = table.Column<int>(type: "int", nullable: false),
                    MachineId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReportDefinitionMachine", x => new { x.ReportDefinitionId, x.MachineId });
                    table.ForeignKey(
                        name: "FK_ReportDefinitionMachine_Machine_MachineId",
                        column: x => x.MachineId,
                        principalTable: "Machine",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReportDefinitionMachine_ReportDefinition_ReportDefinitionId",
                        column: x => x.ReportDefinitionId,
                        principalTable: "ReportDefinition",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ReportDefinitionOperation",
                columns: table => new
                {
                    ReportDefinitionId = table.Column<int>(type: "int", nullable: false),
                    OperationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReportDefinitionOperation", x => new { x.ReportDefinitionId, x.OperationId });
                    table.ForeignKey(
                        name: "FK_ReportDefinitionOperation_Operation_OperationId",
                        column: x => x.OperationId,
                        principalTable: "Operation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReportDefinitionOperation_ReportDefinition_ReportDefinitionId",
                        column: x => x.ReportDefinitionId,
                        principalTable: "ReportDefinition",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ReportDefinitionStatusCode",
                columns: table => new
                {
                    ReportDefinitionId = table.Column<int>(type: "int", nullable: false),
                    StatusCodeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReportDefinitionStatusCode", x => new { x.ReportDefinitionId, x.StatusCodeId });
                    table.ForeignKey(
                        name: "FK_ReportDefinitionStatusCode_ReportDefinition_ReportDefinitionId",
                        column: x => x.ReportDefinitionId,
                        principalTable: "ReportDefinition",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ReportDefinitionStatusCode_StatusCode_StatusCodeId",
                        column: x => x.StatusCodeId,
                        principalTable: "StatusCode",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ReportDefinition_CompanyId",
                table: "ReportDefinition",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_ReportDefinition_ReportSubTypeId",
                table: "ReportDefinition",
                column: "ReportSubTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ReportDefinitionCollector_CollectorId",
                table: "ReportDefinitionCollector",
                column: "CollectorId");

            migrationBuilder.CreateIndex(
                name: "IX_ReportDefinitionJob_JobId",
                table: "ReportDefinitionJob",
                column: "JobId");

            migrationBuilder.CreateIndex(
                name: "IX_ReportDefinitionMachine_MachineId",
                table: "ReportDefinitionMachine",
                column: "MachineId");

            migrationBuilder.CreateIndex(
                name: "IX_ReportDefinitionOperation_OperationId",
                table: "ReportDefinitionOperation",
                column: "OperationId");

            migrationBuilder.CreateIndex(
                name: "IX_ReportDefinitionStatusCode_StatusCodeId",
                table: "ReportDefinitionStatusCode",
                column: "StatusCodeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ReportDefinitionCollector");

            migrationBuilder.DropTable(
                name: "ReportDefinitionJob");

            migrationBuilder.DropTable(
                name: "ReportDefinitionMachine");

            migrationBuilder.DropTable(
                name: "ReportDefinitionOperation");

            migrationBuilder.DropTable(
                name: "ReportDefinitionStatusCode");

            migrationBuilder.DropTable(
                name: "ReportDefinition");

            migrationBuilder.DropTable(
                name: "ReportSubType");
        }
    }
}
