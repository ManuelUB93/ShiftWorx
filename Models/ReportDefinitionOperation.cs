using System.ComponentModel.DataAnnotations.Schema;

namespace ShiftWorx.Models
{
    public class ReportDefinitionOperation
    {
        //[ForeignKey("ReportDefinition")]
        public int ReportDefinitionId { get; set; }
        public ReportDefinition ReportDefinition { get; set; }

        //[ForeignKey("Operation")]
        public int OperationId { get; set; }
        public Operation Operation { get; set; }
    }
}
