using System.ComponentModel.DataAnnotations.Schema;

namespace ShiftWorx.Models
{
    public class ChecklistTemplate : LifeCycleEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Decscription { get; set; }

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
        public ICollection<ChecklistTemplateMachine> MachineOptions { get; set; }
        public ICollection<ChecklistTemplateJob> JobOptions { get; set; }
        public ICollection<ChecklistTemplateOperation> OperationOptions { get; set; }
        public ICollection<ChecklistTemplateFpCoreUser> UserOptions { get; set; }
        public ICollection<ChecklistTemplateFpCoreRole> RoleOptions { get; set; }
        public ICollection<ChecklistTemplateTag> TagOptions { get; set; }
        [NotMapped]
        public List<ChecklistTemplateTag> UserTagOptions => this.TagOptions.Where(e => e.Tag.TagType == TagType.UserCollectors).ToList();
        [NotMapped]
        public List<ChecklistTemplateTag> DataSourceTagOptions => this.TagOptions.Where(e => e.Tag.TagType == TagType.DataSourceCollectors).ToList();

        public string CreatedBy { get; set; } // owner_id:user email or id? of checklist creater

        public virtual ICollection<ChecklistTemplateSection> Sections { get; set; }
        public virtual ICollection<FileAttachment> FileAttachments { get; set; }


        public int fp_core_id { get; set; }

        public Checklist PopulateChecklist()
        {
            Checklist checklist = new Checklist()
            {
                Name = this.Name,
                Decscription = this.Decscription,
                Template = this,
                Company = this.Company,
                IsWorkorder = this.IsWorkorder,
                WorkInstructions = this.WorkInstructions,
                ActiveOn = this.ActiveOn,
                StartedOn = this.StartedOn,
                AssignedOn = this.AssignedOn,
                DueOn = this.DueOn,
                CompletedOn = this.CompletedOn,
                EnabledColumns = this.EnabledColumns,
                EnabledCustomColumns = this.EnabledCustomColumns,
                UnlockedColumns = this.UnlockedColumns,
                CreatedBy = this.CreatedBy,
                Sections = new List<ChecklistSection>()
            };
            foreach (var section in Sections)
            {
                checklist.Sections.Add(section.PopulateChecklistSection(checklist));
            }

            return checklist;
        }
    }
}
