namespace ShiftWorx.Models
{
    public class ChecklistTemplateMachine
    {
        public ChecklistTemplate ChecklistTemplate { get; set; }
        public int ChecklistTemplateId { get; set; }

        public Machine Machine { get; set; }
        public int MachineId { get; set; }
    }
}
