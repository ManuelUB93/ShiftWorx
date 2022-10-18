using System.ComponentModel.DataAnnotations.Schema;

namespace ShiftWorx.Models
{
    public class ChecklistItemRule : LifeCycleEntity
    {
        public int Id { get; set; }

        public ChecklistTemplateItemRule Template { get; set; }
        [ForeignKey("Template")]
        public int? TemplateId { get; set; }

        public ChecklistRuleType Type { get; set; }
        public double CriteriaValue { get; set; }
        public double? CriteriaValue2 { get; set; }
        public bool IsCritical { get; set; }
        public bool? IsFailed(string? stringValue)
        {
            if (string.IsNullOrEmpty(stringValue))
            {
                return null;
            }
            double value;
            double.TryParse(stringValue, out value);
            if (double.IsNaN(value) || double.IsInfinity(value))
            {
                return null;
            }
            switch (Type)
            {
                case ChecklistRuleType.Equal:
                    return value == CriteriaValue;
                case ChecklistRuleType.NotEqual:
                    return value != CriteriaValue;
                case ChecklistRuleType.GreaterThan:
                    return value > CriteriaValue;
                case ChecklistRuleType.GreaterEqual:
                    return value >= CriteriaValue;
                case ChecklistRuleType.LessThan:
                    return value < CriteriaValue;
                case ChecklistRuleType.LessEqual:
                    return value <= CriteriaValue;
                case ChecklistRuleType.Between:
                    return value >= CriteriaValue && value <= CriteriaValue2;
                case ChecklistRuleType.NotBetween:
                    return value < CriteriaValue || value > CriteriaValue2;
            }
            return null;
        }

    }
    public enum ChecklistRuleType
    {
        Equal, NotEqual, GreaterThan, GreaterEqual, LessThan, LessEqual, Between, NotBetween
    }
}
