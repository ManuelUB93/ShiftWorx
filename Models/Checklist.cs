namespace ShiftWorx.Models
{
    public class Checklist: LifeCycleEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Decscription { get; set; }


        public ChecklistTemplate? Template { get; set; }
        public int? TemplateId { get; set; }

        public Company Company { get; set; }
        public int CompanyId { get; set; } 

        public bool IsWorkorder { get; set; }
        public string? WorkInstructions { get; set; }

        public DateTime? ActiveOn { get; set; }
        public DateTime? StartedOn { get; set; }
        public DateTime? AssignedOn { get; set; }
        public DateTime? DueOn { get; set; }
        public DateTime? CompletedOn { get; set; }

        public string? EnabledColumns { get; set; }
        public string? EnabledCustomColumns { get; set; }
        public string? UnlockedColumns { get; set; }
        public int Status { get; set; }
        public bool HasFailed { get; set; }   


        // to attach
        public Machine? Machine { get; set; }
        public int? MachineId { get; set; }
        public Job? Job { get; set; }
        public int? JobId { get; set; }
        public Operation? Operation { get; set; }
        public int? OperationId { get; set; }
        public string CreatedBy { get; set; } // owner_id:user email or id? of checklist creater

        public FpCoreRole? Fp_Core_Role { get; set; }
        public int? Fp_Core_RoleId { get; set; }
        public FpCoreUser? Fp_Core_User { get; set; }
        public int? Fp_Core_UserId { get; set; }
        public Tag? UserTag { get; set; }
        public int? UserTagId { get; set; }
        public Tag? DataSourceTag { get; set; }
        public int? DataSourceTagId { get; set; }

        public virtual ICollection<ChecklistSection> Sections { get; set; }

        public int fp_core_id { get; set; }
    }
}
