using System.ComponentModel.DataAnnotations.Schema;

namespace ShiftWorx.Models
{
    public class ChecklistTemplateItemSelectorOption: LifeCycleEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ChecklistTemplateItemSelector ChecklistTemplateItemSelector { get; set; }
        [ForeignKey ("ChecklistTemplateItemSelector")]
        public int ChecklistTemplateItemSelectorId { get; set; }

        public bool IsPositive { get; set; }
        public int DisplayOrder { get; set; }

        public int fp_core_id { get; set; }

        public ChecklistItemSelectorOption PopulateChecklistItemSelectorOption(ChecklistItemSelector selector = null)
        {
            ChecklistItemSelectorOption option = new ChecklistItemSelectorOption()
            {
                Name = this.Name,
                IsPositive = this.IsPositive,
                DisplayOrder = this.DisplayOrder,
                ChecklistItemSelector = selector,
            };
            
            return option;
        }
    }
}
