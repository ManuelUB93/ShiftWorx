using System.ComponentModel.DataAnnotations.Schema;

namespace ShiftWorx.Models
{
    public class ChecklistSection : LifeCycleEntity
    {
        public int Id { get; set; }

        public ChecklistTemplateSection? Template { get; set; }
        [ForeignKey ("Template")]
        public int? TemplateId { get; set; }

        public string? Heading { get; set; }
        public string? SubHeading { get; set; }

        public ChecklistSectionType SectionType
        {
            get
            {
                if (!string.IsNullOrEmpty(SubHeading))
                {
                    return ChecklistSectionType.Sub;
                }
                if (!string.IsNullOrEmpty(Heading))
                {
                    return ChecklistSectionType.Main;
                }
                return ChecklistSectionType.None;
            }
        }

        public Checklist Checklist { get; set; }
        public int ChecklistId { get; set; }

        public int DisplayOrder { get; set; }

        public virtual ICollection<ChecklistItem> Items { get; set; }

        public int fp_core_id { get; set; }
    }
    public enum ChecklistSectionType
    {
        None, Main, Sub
    }
}
