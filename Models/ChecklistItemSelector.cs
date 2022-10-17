namespace ShiftWorx.Models
{
    public class ChecklistItemSelector: LifeCycleEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ChecklistItem? ChecklistItem { get; set; }
        public int? ChecklistItemId { get; set; }

        public int DisplayOrder { get; set; }
        public virtual ICollection<ChecklistItemSelectorOption> Options { get; set; }

        public int fp_core_id { get; set; }
    }
}
