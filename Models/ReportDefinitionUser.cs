using System.ComponentModel.DataAnnotations.Schema;

namespace ShiftWorx.Models
{
    public class ReportDefinitionUser
    {
        [ForeignKey("ReportDefinition")]
        public int ReportDefinitionId { get; set; }
        public ReportDefinition ReportDefinition { get; set; }
    }
}
