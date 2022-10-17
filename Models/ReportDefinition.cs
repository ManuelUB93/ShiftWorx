using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShiftWorx.Models
{
    public class ReportDefinition: LifeCycleEntity
    {
        [Key]
        public int Id { get; set; }
        
        public string? Name { get; set; }
        public string? Suffix { get; set; }
        public string? Color { get; set; }
        public string? StaticResult { get; set; }
        public int? Divisor { get; set; }
        public int? TickRate { get; set; }
        public bool ScrapAdjust { get; set; }
        public bool ShiftBased { get; set; }
        public bool ActiveShiftBased { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public int? TimeStepSeconds { get; set; }
        public int? Offset { get; set; }
        public int? WindowSizeSeconds { get; set; }

        public int? CreatedBy { get; set; }
        public int? UpdatedBy { get; set; }


        public Factory? Factory { get; set; }
        [ForeignKey ("Factory")]
        public int? FactoryId { get; set; }
        public ReportSubType? ReportSubType { get; set; }
        [ForeignKey("ReportSubType")]
        public int? ReportSubTypeId { get; set; }

        public ReportType? ReportType { get; set; }
        public ChartType? ChartType { get; set; }
        public CalculationWindowTransitionType? CalculationWindowTransitionType { get; set; }
        public TickRateType? TickRateType { get; set; }
        public MathType? MathType { get; set; }
        public ValueType? ValueType { get; set; }
        public ReportRangeType? ReportRangeType { get; set; }
        public int? RollingCalculationWindow { get; set; }

        public CalculationWindowTransitionType? SemiFixedCalculationWindow { get; set; }
        public int? SemiFixedCalculationWindowOffset { get; set; }

        // junction entities
        public ICollection<ReportDefinitionMachine> Machines { get; set; }
        public ICollection<ReportDefinitionCollector> Collectors { get; set; }
        public ICollection<ReportDefinitionJob> Jobs { get; set; }
        public ICollection<ReportDefinitionOperation> Operations { get; set; }
        public ICollection<ReportDefinitionStatusCode> StatusCodes { get; set; } 


        public int fp_core_id { get; set; }
    }

    public enum MathType
    {
        Sum = 1, 
        Average = 2, 
        Min = 3, 
        Max = 4
    }

    public enum ChartType
    {
        Bar = 1, 
        Area = 2, 
        Line = 3, 
        Pie = 4,
        [Description("Stacked Column Chart")]
        StackedColumnChart = 5,
        [Description("Stacked Area Chart")]
        StackedAreaChart = 6,
        [Description("Data Table")]
        DataTable = 7
    }

    public enum CalculationWindowTransitionType
    {
        Shift = 1,
        ShiftWeek = 2,
        Day = 3,
        Month = 4,
        Year = 5,
        Week = 6,
        ShiftMonth = 7,
        ShiftDay = 8
    }

    public enum ReportType
    {
        KPI = 1,
        Report = 2,
        Notification = 3
    }

    public enum ReportRangeType
    {
        TimeRange = 1,
        DataSource = 2,
        Job = 3,
        Operator = 4,
        StuatusCode = 5,
        ScrapType = 6,
        Event = 7
    }

    public enum TickRateType
    {
        Minute = 1,
        Hours = 2,
        Days = 3,
        Months = 4
    }

    public enum ValueType
    {
        Number = 1,
        Percent = 2,
        Text = 3
    }
}
