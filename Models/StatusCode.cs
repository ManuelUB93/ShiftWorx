using System.ComponentModel.DataAnnotations.Schema;

namespace ShiftWorx.Models
{
    // fp_core.operation_codes
    public class StatusCode : LifeCycleEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        public string? Color { get; set; }

        public virtual StatusCategory Category { get; set; }
        [ForeignKey("Category")]
        public int CategoryId { get; set; } 

        public int? fp_core_Id { get; set; }

        public ICollection<ReportDefinitionStatusCode> ReportDefinitions { get; set; }

        public string FullName { get { return Category?.FullName + ": " + Name; } }
        public string ShortcutName { get { return Category?.Name + ": " + Name; } }

        public StatusCode() { }
        public StatusCode(StatusCategory category) 
        {
            Category = category;
            Color = category.Color;
        }

    }
}
