namespace ShiftWorx.Models
{
    public class ChecklistTemplateSection : LifeCycleEntity
    {
        public int Id { get; set; }
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

        public int DisplayOrder { get; set; }

        public virtual ICollection<ChecklistItem> Items { get; set; }

        public int fp_core_id { get; set; }

        public ChecklistSection PopulateChecklistSection(Checklist checklist = null)
        {
            ChecklistSection section = new ChecklistSection()
            {
                Heading = Heading,
                SubHeading = SubHeading,
                Template = this,
                DisplayOrder = DisplayOrder,
                Checklist = checklist,
            };
            return section;
        }
    }
}
