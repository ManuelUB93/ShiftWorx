using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShiftWorx.Models
{
    public class Job : LifeCycleEntity
    {
        [Key]
        public int Id { get; set; }

        public int? JobTemplateId { get; set; }

        [ForeignKey("Factory")]
        public int FactoryId { get; set; }
        public Factory Factory { get; set; }

        [Required]
        [MaxLength(256)]
        public string Name { get; set; }
        public string? Description { get; set; }

        [Display(Name = "Target Count", Prompt = "Enter target count")]
        public int? TargetCount { get; set; }
        [Display(Name = "Target RunRate", Prompt = "Enter Target RunRate")]
        public double? TargetRunrate { get; set; }
        [Display(Name = "Target RunTime", Prompt = "Enter Target RunTime")]
        public double? TargetRuntime { get; set; }
        [Display(Name = "Expected Cycle Time", Prompt = "Enter Expected Cycle Time")]
        public double? ExpectedCycleTime { get; set; }
        [Display(Name = "Expected Cycle Time Deviation", Prompt = "Enter Expected Cycle Time Deviation", Description = "Expected Cycle Time Deviation")]
        public double? ExpectedCycleTimeDeviation { get; set; }

        [MaxLength(191)]
        public string? ClientKey { get; set; }
        public string? CustomerName { get; set; }
        public DateTime? EstmatedStartDate { get; set; }
        public DateTime? PlannedEndDate { get; set; }
        public int? Multiplier { get; set; }
        public int? fp_core_Id { get; set; }

        public bool IsOpen { get; set; }
        //public bool IsArchived { get; set; }

        public TimeScale? RuntimeScale { get; set; }
        public TimeScale? RunRateScale { get; set; } // when using runratescale, it will be 1 / value as double.

        public ICollection<Operation> Operations { get; set; } 
        public ICollection<ReportDefinitionJob> ReportDefinitions { get; set; }

        public Job()
        {
            Operations = new List<Operation>();
        }

    }

    public enum TimeScale
    {
        Sec = 1, Min = 60, Hour = 3600
    }
}
