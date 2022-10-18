using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShiftWorx.Migrations
{
    public partial class AddChecklistAndFileAttachment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "StatusCode",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "StatusCategory",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Color",
                table: "StatusCategory",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Key",
                table: "ReportSubType",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "DisplayName",
                table: "ReportSubType",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Key",
                table: "PanelType",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "PanelTypeKey",
                table: "PanelPreviewInfo",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Panel",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Value",
                table: "Layout",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "Layout",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Layout",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Street",
                table: "Factory",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Province",
                table: "Factory",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "PostalCode",
                table: "Factory",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Longitude",
                table: "Factory",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(3)",
                oldMaxLength: 3);

            migrationBuilder.AlterColumn<string>(
                name: "Latitude",
                table: "Factory",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(3)",
                oldMaxLength: 3);

            migrationBuilder.AlterColumn<string>(
                name: "FactoryKey",
                table: "Factory",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(60)",
                oldMaxLength: 60);

            migrationBuilder.AlterColumn<string>(
                name: "Country",
                table: "Factory",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "Factory",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "fp_core_Id",
                table: "Company",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Street",
                table: "Company",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Province",
                table: "Company",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "PostalCode",
                table: "Company",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Longitude",
                table: "Company",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(3)",
                oldMaxLength: 3);

            migrationBuilder.AlterColumn<string>(
                name: "Latitude",
                table: "Company",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(3)",
                oldMaxLength: 3);

            migrationBuilder.AlterColumn<string>(
                name: "FactoryKey",
                table: "Company",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(60)",
                oldMaxLength: 60);

            migrationBuilder.AlterColumn<string>(
                name: "Country",
                table: "Company",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "Company",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Collector",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256);

            //migrationBuilder.AddColumn<int>(
            //    name: "CompanyId",
            //    table: "AspNetUsers",
            //    type: "int",
            //    nullable: true);

            migrationBuilder.CreateTable(
                name: "ChecklistItemSelector",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChecklistItemId = table.Column<int>(type: "int", nullable: true),
                    DisplayOrder = table.Column<int>(type: "int", nullable: false),
                    fp_core_id = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChecklistItemSelector", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ChecklistTemplate",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Decscription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    IsWorkorder = table.Column<bool>(type: "bit", nullable: false),
                    WorkInstructions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ActiveOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    StartedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AssignedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DueOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CompletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EnabledColumns = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EnabledCustomColumns = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UnlockedColumns = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    HasFailed = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fp_core_id = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChecklistTemplate", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChecklistTemplate_Company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChecklistTemplateItemSelector",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChecklistTemplateItemId = table.Column<int>(type: "int", nullable: true),
                    DisplayOrder = table.Column<int>(type: "int", nullable: false),
                    fp_core_id = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChecklistTemplateItemSelector", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ChecklistTemplateRule",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<int>(type: "int", nullable: false),
                    CriteriaValue = table.Column<double>(type: "float", nullable: false),
                    CriteriaValue2 = table.Column<double>(type: "float", nullable: true),
                    IsCritical = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChecklistTemplateRule", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FpCoreRole",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyId = table.Column<int>(type: "int", nullable: true),
                    IsHidden = table.Column<bool>(type: "bit", nullable: false),
                    IsLocked = table.Column<bool>(type: "bit", nullable: true),
                    fp_core_Id = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FpCoreRole", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FpCoreRole_Company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Company",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Tag",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TagType = table.Column<int>(type: "int", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fp_core_id = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tag", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tag_Company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChecklistItemSelectorOption",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChecklistItemSelectorId = table.Column<int>(type: "int", nullable: false),
                    IsPositive = table.Column<bool>(type: "bit", nullable: false),
                    DisplayOrder = table.Column<int>(type: "int", nullable: false),
                    fp_core_id = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChecklistItemSelectorOption", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChecklistItemSelectorOption_ChecklistItemSelector_ChecklistItemSelectorId",
                        column: x => x.ChecklistItemSelectorId,
                        principalTable: "ChecklistItemSelector",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChecklistTemplateJob",
                columns: table => new
                {
                    ChecklistTemplateId = table.Column<int>(type: "int", nullable: false),
                    JobId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChecklistTemplateJob", x => new { x.ChecklistTemplateId, x.JobId });
                    table.ForeignKey(
                        name: "FK_ChecklistTemplateJob_ChecklistTemplate_ChecklistTemplateId",
                        column: x => x.ChecklistTemplateId,
                        principalTable: "ChecklistTemplate",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ChecklistTemplateJob_Job_JobId",
                        column: x => x.JobId,
                        principalTable: "Job",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "ChecklistTemplateMachine",
                columns: table => new
                {
                    ChecklistTemplateId = table.Column<int>(type: "int", nullable: false),
                    MachineId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChecklistTemplateMachine", x => new { x.ChecklistTemplateId, x.MachineId });
                    table.ForeignKey(
                        name: "FK_ChecklistTemplateMachine_ChecklistTemplate_ChecklistTemplateId",
                        column: x => x.ChecklistTemplateId,
                        principalTable: "ChecklistTemplate",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChecklistTemplateMachine_Machine_MachineId",
                        column: x => x.MachineId,
                        principalTable: "Machine",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChecklistTemplateOperation",
                columns: table => new
                {
                    ChecklistTemplateId = table.Column<int>(type: "int", nullable: false),
                    OperationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChecklistTemplateOperation", x => new { x.ChecklistTemplateId, x.OperationId });
                    table.ForeignKey(
                        name: "FK_ChecklistTemplateOperation_ChecklistTemplate_ChecklistTemplateId",
                        column: x => x.ChecklistTemplateId,
                        principalTable: "ChecklistTemplate",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChecklistTemplateOperation_Operation_OperationId",
                        column: x => x.OperationId,
                        principalTable: "Operation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChecklistTemplateSection",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Heading = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubHeading = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DisplayOrder = table.Column<int>(type: "int", nullable: false),
                    fp_core_id = table.Column<int>(type: "int", nullable: false),
                    ChecklistTemplateId = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChecklistTemplateSection", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChecklistTemplateSection_ChecklistTemplate_ChecklistTemplateId",
                        column: x => x.ChecklistTemplateId,
                        principalTable: "ChecklistTemplate",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ChecklistTemplateItemSelectorOption",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChecklistTemplateItemSelectorId = table.Column<int>(type: "int", nullable: false),
                    IsPositive = table.Column<bool>(type: "bit", nullable: false),
                    DisplayOrder = table.Column<int>(type: "int", nullable: false),
                    fp_core_id = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChecklistTemplateItemSelectorOption", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChecklistTemplateItemSelectorOption_ChecklistTemplateItemSelector_ChecklistTemplateItemSelectorId",
                        column: x => x.ChecklistTemplateItemSelectorId,
                        principalTable: "ChecklistTemplateItemSelector",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChecklistRule",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TemplateId = table.Column<int>(type: "int", nullable: true),
                    Type = table.Column<int>(type: "int", nullable: false),
                    CriteriaValue = table.Column<double>(type: "float", nullable: false),
                    CriteriaValue2 = table.Column<double>(type: "float", nullable: true),
                    IsCritical = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChecklistRule", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChecklistRule_ChecklistTemplateRule_TemplateId",
                        column: x => x.TemplateId,
                        principalTable: "ChecklistTemplateRule",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "FpCoreUser",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    fp_core_Id = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FpCoreUser", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FpCoreUser_FpCoreRole_RoleId",
                        column: x => x.RoleId,
                        principalTable: "FpCoreRole",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChecklistTemplateTag",
                columns: table => new
                {
                    ChecklistTemplateId = table.Column<int>(type: "int", nullable: false),
                    TagId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChecklistTemplateTag", x => new { x.ChecklistTemplateId, x.TagId });
                    table.ForeignKey(
                        name: "FK_ChecklistTemplateTag_ChecklistTemplate_ChecklistTemplateId",
                        column: x => x.ChecklistTemplateId,
                        principalTable: "ChecklistTemplate",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ChecklistTemplateTag_Tag_TagId",
                        column: x => x.TagId,
                        principalTable: "Tag",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "ChecklistTemplateItem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Decscription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserNotes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsRuleEnabled = table.Column<bool>(type: "bit", nullable: false),
                    RuleId = table.Column<int>(type: "int", nullable: true),
                    DataType = table.Column<int>(type: "int", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Units = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DecimalPlaces = table.Column<int>(type: "int", nullable: false),
                    Masking = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Identifier = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SelecterOptionValues = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HasValue = table.Column<bool>(type: "bit", nullable: false),
                    HasSelector = table.Column<bool>(type: "bit", nullable: false),
                    VslueRequired = table.Column<bool>(type: "bit", nullable: false),
                    DisplayOrder = table.Column<int>(type: "int", nullable: false),
                    SectionId = table.Column<int>(type: "int", nullable: false),
                    SelectorId = table.Column<int>(type: "int", nullable: true),
                    ChecklistId = table.Column<int>(type: "int", nullable: true),
                    fp_core_id = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChecklistTemplateItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChecklistTemplateItem_ChecklistTemplateItemSelector_SelectorId",
                        column: x => x.SelectorId,
                        principalTable: "ChecklistTemplateItemSelector",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ChecklistTemplateItem_ChecklistTemplateRule_RuleId",
                        column: x => x.RuleId,
                        principalTable: "ChecklistTemplateRule",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ChecklistTemplateItem_ChecklistTemplateSection_SectionId",
                        column: x => x.SectionId,
                        principalTable: "ChecklistTemplateSection",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Checklist",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Decscription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TemplateId = table.Column<int>(type: "int", nullable: true),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    IsWorkorder = table.Column<bool>(type: "bit", nullable: false),
                    WorkInstructions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ActiveOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    StartedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AssignedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DueOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CompletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EnabledColumns = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EnabledCustomColumns = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UnlockedColumns = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    HasFailed = table.Column<bool>(type: "bit", nullable: false),
                    MachineId = table.Column<int>(type: "int", nullable: true),
                    JobId = table.Column<int>(type: "int", nullable: true),
                    OperationId = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fp_Core_RoleId = table.Column<int>(type: "int", nullable: true),
                    Fp_Core_UserId = table.Column<int>(type: "int", nullable: true),
                    UserTagId = table.Column<int>(type: "int", nullable: true),
                    DataSourceTagId = table.Column<int>(type: "int", nullable: true),
                    fp_core_id = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Checklist", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Checklist_ChecklistTemplate_TemplateId",
                        column: x => x.TemplateId,
                        principalTable: "ChecklistTemplate",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Checklist_Company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Checklist_FpCoreRole_Fp_Core_RoleId",
                        column: x => x.Fp_Core_RoleId,
                        principalTable: "FpCoreRole",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Checklist_FpCoreUser_Fp_Core_UserId",
                        column: x => x.Fp_Core_UserId,
                        principalTable: "FpCoreUser",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Checklist_Job_JobId",
                        column: x => x.JobId,
                        principalTable: "Job",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Checklist_Machine_MachineId",
                        column: x => x.MachineId,
                        principalTable: "Machine",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Checklist_Operation_OperationId",
                        column: x => x.OperationId,
                        principalTable: "Operation",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Checklist_Tag_DataSourceTagId",
                        column: x => x.DataSourceTagId,
                        principalTable: "Tag",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Checklist_Tag_UserTagId",
                        column: x => x.UserTagId,
                        principalTable: "Tag",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ChecklistTemplateFpCoreRole",
                columns: table => new
                {
                    ChecklistTemplateId = table.Column<int>(type: "int", nullable: false),
                    FpCoreRoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChecklistTemplateFpCoreRole", x => new { x.ChecklistTemplateId, x.FpCoreRoleId });
                    table.ForeignKey(
                        name: "FK_ChecklistTemplateFpCoreRole_ChecklistTemplate_ChecklistTemplateId",
                        column: x => x.ChecklistTemplateId,
                        principalTable: "ChecklistTemplate",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChecklistTemplateFpCoreRole_FpCoreUser_FpCoreRoleId",
                        column: x => x.FpCoreRoleId,
                        principalTable: "FpCoreUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChecklistTemplateFpCoreUser",
                columns: table => new
                {
                    ChecklistTemplateId = table.Column<int>(type: "int", nullable: false),
                    FpCoreUserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChecklistTemplateFpCoreUser", x => new { x.ChecklistTemplateId, x.FpCoreUserId });
                    table.ForeignKey(
                        name: "FK_ChecklistTemplateFpCoreUser_ChecklistTemplate_ChecklistTemplateId",
                        column: x => x.ChecklistTemplateId,
                        principalTable: "ChecklistTemplate",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChecklistTemplateFpCoreUser_FpCoreUser_FpCoreUserId",
                        column: x => x.FpCoreUserId,
                        principalTable: "FpCoreUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChecklistSection",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TemplateId = table.Column<int>(type: "int", nullable: true),
                    Heading = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubHeading = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChecklistId = table.Column<int>(type: "int", nullable: false),
                    DisplayOrder = table.Column<int>(type: "int", nullable: false),
                    fp_core_id = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChecklistSection", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChecklistSection_Checklist_ChecklistId",
                        column: x => x.ChecklistId,
                        principalTable: "Checklist",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChecklistSection_ChecklistTemplateSection_TemplateId",
                        column: x => x.TemplateId,
                        principalTable: "ChecklistTemplateSection",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ChecklistItem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TemplateId = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Decscription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserNotes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsRuleEnabled = table.Column<bool>(type: "bit", nullable: false),
                    RuleId = table.Column<int>(type: "int", nullable: true),
                    DataType = table.Column<int>(type: "int", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Units = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DecimalPlaces = table.Column<int>(type: "int", nullable: false),
                    Masking = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Identifier = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HasValue = table.Column<bool>(type: "bit", nullable: false),
                    HasSelector = table.Column<bool>(type: "bit", nullable: false),
                    VslueRequired = table.Column<bool>(type: "bit", nullable: false),
                    DisplayOrder = table.Column<int>(type: "int", nullable: false),
                    SectionId = table.Column<int>(type: "int", nullable: false),
                    SelectorId = table.Column<int>(type: "int", nullable: true),
                    SelectedOptionId = table.Column<int>(type: "int", nullable: true),
                    ChecklistId = table.Column<int>(type: "int", nullable: true),
                    fp_core_id = table.Column<int>(type: "int", nullable: false),
                    ChecklistTemplateSectionId = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChecklistItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChecklistItem_ChecklistItemSelector_SelectorId",
                        column: x => x.SelectorId,
                        principalTable: "ChecklistItemSelector",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ChecklistItem_ChecklistItemSelectorOption_SelectedOptionId",
                        column: x => x.SelectedOptionId,
                        principalTable: "ChecklistItemSelectorOption",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ChecklistItem_ChecklistRule_RuleId",
                        column: x => x.RuleId,
                        principalTable: "ChecklistRule",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ChecklistItem_ChecklistSection_SectionId",
                        column: x => x.SectionId,
                        principalTable: "ChecklistSection",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChecklistItem_ChecklistTemplateItem_TemplateId",
                        column: x => x.TemplateId,
                        principalTable: "ChecklistTemplateItem",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ChecklistItem_ChecklistTemplateSection_ChecklistTemplateSectionId",
                        column: x => x.ChecklistTemplateSectionId,
                        principalTable: "ChecklistTemplateSection",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "FileAttachment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FileName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Container = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FileExt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BlobId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Uri = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UploadedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Size = table.Column<double>(type: "float", nullable: false),
                    fp_core_id = table.Column<int>(type: "int", nullable: true),
                    ChecklistId = table.Column<int>(type: "int", nullable: true),
                    ChecklistItemId = table.Column<int>(type: "int", nullable: true),
                    ChecklistTemplateId = table.Column<int>(type: "int", nullable: true),
                    ChecklistTemplateItemId = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FileAttachment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FileAttachment_Checklist_ChecklistId",
                        column: x => x.ChecklistId,
                        principalTable: "Checklist",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_FileAttachment_ChecklistItem_ChecklistItemId",
                        column: x => x.ChecklistItemId,
                        principalTable: "ChecklistItem",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_FileAttachment_ChecklistTemplate_ChecklistTemplateId",
                        column: x => x.ChecklistTemplateId,
                        principalTable: "ChecklistTemplate",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_FileAttachment_ChecklistTemplateItem_ChecklistTemplateItemId",
                        column: x => x.ChecklistTemplateItemId,
                        principalTable: "ChecklistTemplateItem",
                        principalColumn: "Id");
                });

            //migrationBuilder.CreateIndex(
            //    name: "IX_AspNetUsers_CompanyId",
            //    table: "AspNetUsers",
            //    column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Checklist_CompanyId",
                table: "Checklist",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Checklist_DataSourceTagId",
                table: "Checklist",
                column: "DataSourceTagId");

            migrationBuilder.CreateIndex(
                name: "IX_Checklist_Fp_Core_RoleId",
                table: "Checklist",
                column: "Fp_Core_RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Checklist_Fp_Core_UserId",
                table: "Checklist",
                column: "Fp_Core_UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Checklist_JobId",
                table: "Checklist",
                column: "JobId");

            migrationBuilder.CreateIndex(
                name: "IX_Checklist_MachineId",
                table: "Checklist",
                column: "MachineId");

            migrationBuilder.CreateIndex(
                name: "IX_Checklist_OperationId",
                table: "Checklist",
                column: "OperationId");

            migrationBuilder.CreateIndex(
                name: "IX_Checklist_TemplateId",
                table: "Checklist",
                column: "TemplateId");

            migrationBuilder.CreateIndex(
                name: "IX_Checklist_UserTagId",
                table: "Checklist",
                column: "UserTagId");

            migrationBuilder.CreateIndex(
                name: "IX_ChecklistItem_ChecklistTemplateSectionId",
                table: "ChecklistItem",
                column: "ChecklistTemplateSectionId");

            migrationBuilder.CreateIndex(
                name: "IX_ChecklistItem_RuleId",
                table: "ChecklistItem",
                column: "RuleId");

            migrationBuilder.CreateIndex(
                name: "IX_ChecklistItem_SectionId",
                table: "ChecklistItem",
                column: "SectionId");

            migrationBuilder.CreateIndex(
                name: "IX_ChecklistItem_SelectedOptionId",
                table: "ChecklistItem",
                column: "SelectedOptionId");

            migrationBuilder.CreateIndex(
                name: "IX_ChecklistItem_SelectorId",
                table: "ChecklistItem",
                column: "SelectorId",
                unique: true,
                filter: "[SelectorId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ChecklistItem_TemplateId",
                table: "ChecklistItem",
                column: "TemplateId");

            migrationBuilder.CreateIndex(
                name: "IX_ChecklistItemSelectorOption_ChecklistItemSelectorId",
                table: "ChecklistItemSelectorOption",
                column: "ChecklistItemSelectorId");

            migrationBuilder.CreateIndex(
                name: "IX_ChecklistRule_TemplateId",
                table: "ChecklistRule",
                column: "TemplateId");

            migrationBuilder.CreateIndex(
                name: "IX_ChecklistSection_ChecklistId",
                table: "ChecklistSection",
                column: "ChecklistId");

            migrationBuilder.CreateIndex(
                name: "IX_ChecklistSection_TemplateId",
                table: "ChecklistSection",
                column: "TemplateId");

            migrationBuilder.CreateIndex(
                name: "IX_ChecklistTemplate_CompanyId",
                table: "ChecklistTemplate",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_ChecklistTemplateFpCoreRole_FpCoreRoleId",
                table: "ChecklistTemplateFpCoreRole",
                column: "FpCoreRoleId");

            migrationBuilder.CreateIndex(
                name: "IX_ChecklistTemplateFpCoreUser_FpCoreUserId",
                table: "ChecklistTemplateFpCoreUser",
                column: "FpCoreUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ChecklistTemplateItem_RuleId",
                table: "ChecklistTemplateItem",
                column: "RuleId");

            migrationBuilder.CreateIndex(
                name: "IX_ChecklistTemplateItem_SectionId",
                table: "ChecklistTemplateItem",
                column: "SectionId");

            migrationBuilder.CreateIndex(
                name: "IX_ChecklistTemplateItem_SelectorId",
                table: "ChecklistTemplateItem",
                column: "SelectorId",
                unique: true,
                filter: "[SelectorId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ChecklistTemplateItemSelectorOption_ChecklistTemplateItemSelectorId",
                table: "ChecklistTemplateItemSelectorOption",
                column: "ChecklistTemplateItemSelectorId");

            migrationBuilder.CreateIndex(
                name: "IX_ChecklistTemplateJob_JobId",
                table: "ChecklistTemplateJob",
                column: "JobId");

            migrationBuilder.CreateIndex(
                name: "IX_ChecklistTemplateMachine_MachineId",
                table: "ChecklistTemplateMachine",
                column: "MachineId");

            migrationBuilder.CreateIndex(
                name: "IX_ChecklistTemplateOperation_OperationId",
                table: "ChecklistTemplateOperation",
                column: "OperationId");

            migrationBuilder.CreateIndex(
                name: "IX_ChecklistTemplateSection_ChecklistTemplateId",
                table: "ChecklistTemplateSection",
                column: "ChecklistTemplateId");

            migrationBuilder.CreateIndex(
                name: "IX_ChecklistTemplateTag_TagId",
                table: "ChecklistTemplateTag",
                column: "TagId");

            migrationBuilder.CreateIndex(
                name: "IX_FileAttachment_ChecklistId",
                table: "FileAttachment",
                column: "ChecklistId");

            migrationBuilder.CreateIndex(
                name: "IX_FileAttachment_ChecklistItemId",
                table: "FileAttachment",
                column: "ChecklistItemId");

            migrationBuilder.CreateIndex(
                name: "IX_FileAttachment_ChecklistTemplateId",
                table: "FileAttachment",
                column: "ChecklistTemplateId");

            migrationBuilder.CreateIndex(
                name: "IX_FileAttachment_ChecklistTemplateItemId",
                table: "FileAttachment",
                column: "ChecklistTemplateItemId");

            migrationBuilder.CreateIndex(
                name: "IX_FpCoreRole_CompanyId",
                table: "FpCoreRole",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_FpCoreUser_RoleId",
                table: "FpCoreUser",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Tag_CompanyId",
                table: "Tag",
                column: "CompanyId");

            //migrationBuilder.AddForeignKey(
            //    name: "FK_AspNetUsers_Company_CompanyId",
            //    table: "AspNetUsers",
            //    column: "CompanyId",
            //    principalTable: "Company",
            //    principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropForeignKey(
            //    name: "FK_AspNetUsers_Company_CompanyId",
            //    table: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "ChecklistTemplateFpCoreRole");

            migrationBuilder.DropTable(
                name: "ChecklistTemplateFpCoreUser");

            migrationBuilder.DropTable(
                name: "ChecklistTemplateItemSelectorOption");

            migrationBuilder.DropTable(
                name: "ChecklistTemplateJob");

            migrationBuilder.DropTable(
                name: "ChecklistTemplateMachine");

            migrationBuilder.DropTable(
                name: "ChecklistTemplateOperation");

            migrationBuilder.DropTable(
                name: "ChecklistTemplateTag");

            migrationBuilder.DropTable(
                name: "FileAttachment");

            migrationBuilder.DropTable(
                name: "ChecklistItem");

            migrationBuilder.DropTable(
                name: "ChecklistItemSelectorOption");

            migrationBuilder.DropTable(
                name: "ChecklistRule");

            migrationBuilder.DropTable(
                name: "ChecklistSection");

            migrationBuilder.DropTable(
                name: "ChecklistTemplateItem");

            migrationBuilder.DropTable(
                name: "ChecklistItemSelector");

            migrationBuilder.DropTable(
                name: "Checklist");

            migrationBuilder.DropTable(
                name: "ChecklistTemplateItemSelector");

            migrationBuilder.DropTable(
                name: "ChecklistTemplateRule");

            migrationBuilder.DropTable(
                name: "ChecklistTemplateSection");

            migrationBuilder.DropTable(
                name: "FpCoreUser");

            migrationBuilder.DropTable(
                name: "Tag");

            migrationBuilder.DropTable(
                name: "ChecklistTemplate");

            migrationBuilder.DropTable(
                name: "FpCoreRole");

            //migrationBuilder.DropIndex(
            //    name: "IX_AspNetUsers_CompanyId",
            //    table: "AspNetUsers");

            //migrationBuilder.DropColumn(
            //    name: "CompanyId",
            //    table: "AspNetUsers");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "StatusCode",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "StatusCategory",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Color",
                table: "StatusCategory",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Key",
                table: "ReportSubType",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DisplayName",
                table: "ReportSubType",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Key",
                table: "PanelType",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PanelTypeKey",
                table: "PanelPreviewInfo",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Panel",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Value",
                table: "Layout",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "Layout",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Layout",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Street",
                table: "Factory",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Province",
                table: "Factory",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PostalCode",
                table: "Factory",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Longitude",
                table: "Factory",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(3)",
                oldMaxLength: 3,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Latitude",
                table: "Factory",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(3)",
                oldMaxLength: 3,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FactoryKey",
                table: "Factory",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(60)",
                oldMaxLength: 60,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Country",
                table: "Factory",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "Factory",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "fp_core_Id",
                table: "Company",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Street",
                table: "Company",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Province",
                table: "Company",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PostalCode",
                table: "Company",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Longitude",
                table: "Company",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(3)",
                oldMaxLength: 3,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Latitude",
                table: "Company",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(3)",
                oldMaxLength: 3,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FactoryKey",
                table: "Company",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(60)",
                oldMaxLength: 60,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Country",
                table: "Company",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "Company",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Collector",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            //migrationBuilder.CreateTable(
            //    name: "IdentityAuth",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        CompanyId = table.Column<int>(type: "int", nullable: false),
            //        UserId = table.Column<string>(type: "nvarchar(max)", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_IdentityAuth", x => x.Id);
            //    });
        }
    }
}
