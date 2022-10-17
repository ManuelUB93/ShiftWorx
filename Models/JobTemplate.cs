using System.ComponentModel.DataAnnotations;

namespace ShiftWorx.Models
{
    public class JobTemplate : LifeCycleEntity
    {
        public int Id { get; set; }

        public Factory? Factory { get; set; }
        public int? FactoryId { get; set; }
       
        [MaxLength(256)]
        public string? Name { get; set; }
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

        // from fc_core
        public string? ClientKey { get; set; }
        public string? CustomerName { get; set; }
        public DateTime? EstmatedStartDate { get; set; }
        public DateTime? PlannedEndDate { get; set; }
        public int? Multiplier { get; set; }
        public int fp_core_Id { get; set; }


        public bool IsOpen { get; set; }
        //public bool IsArchived { get; set; }

        public TimeScale? RuntimeScale { get; set; }
        public TimeScale? RunRateScale { get; set; } // when using runratescale, it will be 1 / value as double.

        public ICollection<OperationTemplate> Operations { get; set; }

        public JobTemplate()
        {
            Operations = new List<OperationTemplate>();
        }

        public Job CreateJob()
        {
            Job job = new()
            {
                JobTemplateId = Id,
                Name = this.Name ?? "",
                Description = this.Description,
                ClientKey = this.ClientKey,
                FactoryId = this.FactoryId ?? 0,
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

            foreach(var op in this.Operations)
            {
                job.Operations.Add(op.CreateOperation());
            }
            return job;
        }
    }
}
