using System.ComponentModel.DataAnnotations.Schema;

namespace ShiftWorx.Models
{
    public class ReportDefinitionJob
    {
        //[ForeignKey("ReportDefinition")]
        public int ReportDefinitionId { get; set; }
        public ReportDefinition ReportDefinition { get; set; }

        //[ForeignKey("Job")]
        public int JobId { get; set; }
        public Job Job { get; set; }
    }
}
