namespace ShiftWorx.Models
{
    public class ChecklistItemSection : LifeCycleEntity
    {
        public int Id { get; set; }
        public string? Heading { get; set; }
        public string? Group { get; set; }
        public ChecklistItemSectionType Type
        {
            get
            {
                if (Heading == null)
                {
                    if (Group == null)
                    {
                        return ChecklistItemSectionType.None;
                    }
                    return ChecklistItemSectionType.Main;
                }
                if (Group == null)
                {
                    return ChecklistItemSectionType.Main;
                }
                return ChecklistItemSectionType.Sub;
            }
        }

        public ChecklistTemplate? ChecklistTemplate { get; set; }
        public int? ChecklistTemplateId { get; set; }
        public Checklist? Checklist { get; set; }
        public int? ChecklistId { get; set; }
        public int Order { get; set; }

        public virtual ICollection<ChecklistItem> Items { get; set; }

        public int fp_core_id { get; set; }
    }
    public enum ChecklistItemSectionType
    {
        None, Main, Sub
    }
}
