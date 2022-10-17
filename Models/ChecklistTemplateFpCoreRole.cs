namespace ShiftWorx.Models
{
    public class ChecklistTemplateFpCoreRole
    {
        public ChecklistTemplate ChecklistTemplate { get; set; }
        public int ChecklistTemplateId { get; set; }

        public FpCoreUser FpCoreRole { get; set; }
        public int FpCoreRoleId { get; set; }
    }
}
