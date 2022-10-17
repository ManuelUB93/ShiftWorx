namespace ShiftWorx.Models
{
    public class ChecklistTemplateTag
    {
        public ChecklistTemplate ChecklistTemplate { get; set; }
        public int ChecklistTemplateId { get; set; }

        public Tag Tag { get; set; }
        public int TagId { get; set; }
    }
}