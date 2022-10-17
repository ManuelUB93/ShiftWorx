namespace ShiftWorx.Models
{
    public class ChecklistItemSelectorOption : LifeCycleEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ChecklistItemSelector ChecklistItemSelector { get; set; }
        public int ChecklistItemSelectorId { get; set; }

        public bool IsPositive { get; set; }
        public int DisplayOrder { get; set; }

        public int fp_core_id { get; set; }

    }
}
