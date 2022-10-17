namespace ShiftWorx.Models
{
    public class ReportDefinitionCollector
    {
        public int ReportDefinitionId { get; set; }
        public ReportDefinition ReportDefinition { get; set; }

        public int CollectorId { get; set; }
        public Collector Collector { get; set; }
    }
}
