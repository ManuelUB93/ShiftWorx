using System.ComponentModel.DataAnnotations.Schema;

namespace ShiftWorx.Models
{
    public class ChecklistItem : LifeCycleEntity
    {
        public int Id { get; set; }

        public ChecklistTemplateItem Template { get; set; }
        [ForeignKey("Template")]
        public int? TemplateId { get; set; }
        
        public string Name { get; set; }
        public string? Decscription { get; set; }
        public string? UserNotes { get; set; }
 
        public bool IsRuleEnabled { get; set; }
        public ChecklistRule? Rule { get; set; }
        [ForeignKey ("Rule")]
        public int? RuleId { get; set; }

        public ChecklistItemDataType DataType { get; set; }
        public string? Value { get; set; }
        public bool? IsFailed { get { return Rule.IsFailed(Value); } }
        public string Units { get; set; }
        public int DecimalPlaces { get; set; }
        public string Masking { get; set; }
        public string Identifier { get; set; }
        public bool HasValue { get; set; }
        public bool HasSelector { get; set; }
        public bool VslueRequired { get; set; }

        public int DisplayOrder { get; set; }

        public ChecklistSection Section { get; set; }
        [ForeignKey("Section")]
        public int SectionId { get; set; }

        public ChecklistItemSelector? Selector { get; set; }
        [ForeignKey("Selector")]
        public int? SelectorId { get; set; }

        public ChecklistItemSelectorOption? SelectedOption { get; set; }
        [ForeignKey("SelectedOption")]
        public int? SelectedOptionId { get; set; }

        public int? ChecklistId { get; set; }

        public int fp_core_id { get; set; }

    }

    public enum ChecklistItemDataType
    {
        Text = 1, Number = 2, DateTime = 3, String = 4, Boolean = 5, DateTimeOffset = 6,
    }
}
