using System.ComponentModel.DataAnnotations.Schema;

namespace ShiftWorx.Models
{
    public class ChecklistTemplateItem : LifeCycleEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Decscription { get; set; }
        public string? UserNotes { get; set; }

        public bool IsRuleEnabled { get; set; }
        public ChecklistTemplateRule? Rule { get; set; }
        [ForeignKey("Rule")]
        public int? RuleId { get; set; }

        public ChecklistItemDataType DataType { get; set; }
        public string? Value { get; set; }
        public bool? IsFailed { get { return Rule.IsFailed(Value); } }
        public string Units { get; set; }
        public int DecimalPlaces { get; set; }
        public string Masking { get; set; }
        public string Identifier { get; set; }
        public string SelecterOptionValues { get; set; }
        public bool HasValue { get; set; }
        public bool HasSelector { get; set; }
        public bool VslueRequired { get; set; }

        public int DisplayOrder { get; set; }

        public ChecklistTemplateSection Section { get; set; }
        [ForeignKey("Section")]
        public int SectionId { get; set; }

        public ChecklistTemplateItemSelector? Selector { get; set; }
        [ForeignKey("Selector")]
        public int? SelectorId { get; set; }

        public int? ChecklistId { get; set; }

        public int fp_core_id { get; set; }

        public ChecklistItem PopulateChecklistItem(ChecklistSection section = null)
        {
            ChecklistItem item = new ChecklistItem()
            {
                Template = this,
                Name = this.Name,
                Decscription = this.Decscription,
                UserNotes = this.UserNotes,
                IsRuleEnabled = this.IsRuleEnabled,
                Rule = this.Rule.PopulateChecklistRule(),
                DataType = this.DataType,
                Value = this.Value,
                Units = this.Units,
                DecimalPlaces = this.DecimalPlaces,
                Masking = this.Masking,
                Identifier = this.Identifier,
                HasValue = this.HasValue,
                HasSelector = this.HasSelector,
                DisplayOrder = this.DisplayOrder,
                Section = section,
            };
            item.Selector = this.Selector.PopulateChecklistItemSelector(item);

            return item;
        }
    }
}
