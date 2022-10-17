using System.ComponentModel.DataAnnotations.Schema;

namespace ShiftWorx.Models
{
    public class ReportDefinitionStatusCode
    {        
        //[ForeignKey("ReportDefinition")]
        public int ReportDefinitionId { get; set; }
        public ReportDefinition ReportDefinition { get; set; }

        //[ForeignKey("StatusCode")]
        public int StatusCodeId { get; set; }
        public StatusCode StatusCode { get; set; }
    }
}
