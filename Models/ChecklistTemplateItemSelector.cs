namespace ShiftWorx.Models
{
    public class ChecklistTemplateItemSelector : LifeCycleEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ChecklistTemplateItem? ChecklistTemplateItem { get; set; }
        public int? ChecklistTemplateItemId { get; set; }

        public int DisplayOrder { get; set; }
        public virtual ICollection<ChecklistTemplateItemSelectorOption> Options { get; set; }

        public int fp_core_id { get; set; }

        public ChecklistItemSelector PopulateChecklistItemSelector(ChecklistItem item = null)
        {
            ChecklistItemSelector selector = new ChecklistItemSelector()
            {
                Name = this.Name,
                ChecklistItem = item,
                DisplayOrder = this.DisplayOrder,
                Options = new List<ChecklistItemSelectorOption>()
            };
            foreach(var option in this.Options)
            {
                selector.Options.Add(option.PopulateChecklistItemSelectorOption(selector));
            }
            return selector;
        }
    }
}
