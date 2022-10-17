namespace ShiftWorx.Models
{
    public class ReportDefinitionMachine
    {
        public int ReportDefinitionId { get; set; }
        public ReportDefinition ReportDefinition { get; set; }

        public int MachineId { get; set; }
        public Machine Machine { get; set; }

    }
}
