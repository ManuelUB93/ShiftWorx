namespace ShiftWorx.Models
{
    public class ChecklistTemplateOperation
    {
        public ChecklistTemplate ChecklistTemplate { get; set; }
        public int ChecklistTemplateId { get; set; }

        public Operation Operation { get; set; }
        public int OperationId { get; set; }
    }
}
