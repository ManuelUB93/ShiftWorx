namespace ShiftWorx.Models
{
    public class ChecklistTemplateJob
    {
        public ChecklistTemplate ChecklistTemplate { get; set; }
        public int ChecklistTemplateId { get; set; }

        public Job Job { get; set; }
        public int JobId { get; set; }
    }
}
