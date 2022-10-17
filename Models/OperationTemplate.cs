using System.ComponentModel.DataAnnotations;

namespace ShiftWorx.Models
{
    public class OperationTemplate : LifeCycleEntity
    {
        public int Id { get; set; }

        public JobTemplate? JobTemplate { get; set; }
        public int? JobTemplateId { get; set; }

        [MaxLength(256)]
        public string? Name { get; set; }
        public string? Description { get; set; }
        [MaxLength(60)]
        public string? Group { get; set; }

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

        // from fc_core
        public string? ClientKey { get; set; }
        public DateTime? EstmatedStartDate { get; set; }
        public DateTime? PlannedEndDate { get; set; }
        public int? Multiplier { get; set; }
        public int fp_core_Id { get; set; }

        public TimeScale? RuntimeScale { get; set; }
        public TimeScale? RunRateScale { get; set; } // when using runratescale, it will be 1 / value as double.

        public Operation CreateOperation()
        {
            Operation operation = new Operation()
            {
                Name = this.Name ?? "",
                Description = this.Description,
                OperationTemplateId = this.Id,
                Group = this.Group,
                ClientKey = this.ClientKey,
                EstmatedStartDate = this.EstmatedStartDate,
                PlannedEndDate = this.PlannedEndDate,
                Multiplier = this.Multiplier,
                TargetCount = this.TargetCount,
                TargetRunrate = this.TargetRunrate,
                TargetRuntime = this.TargetRuntime,
                ExpectedCycleTime = this.ExpectedCycleTime,
                ExpectedCycleTimeDeviation = this.ExpectedCycleTimeDeviation,
                RunRateScale = this.RunRateScale,
                RuntimeScale = this.RuntimeScale,
            };
            return operation;
        }
    }

    public class OperationTemplateViewModel
    {
        public int ParentId { get; set; }
        public OperationTemplate MainModel { get; set; }
        public List<OperationTemplate> Children { get; set; }
    }
}
