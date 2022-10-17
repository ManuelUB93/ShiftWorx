namespace ShiftWorx.Models
{
    public class ChecklistTemplateFpCoreUser
    {
        public ChecklistTemplate ChecklistTemplate { get; set; }
        public int ChecklistTemplateId { get; set; }

        public FpCoreUser FpCoreUser { get; set; }
        public int FpCoreUserId { get; set; }
    }
}
