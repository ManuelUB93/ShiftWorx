namespace ShiftWorx.Models
{
    public class ReportSubType: LifeCycleEntity
    {
        public int Id { get; set; }
        public string Key { get; set; }
        public string DisplayName { get; set; }
        public int DisplayOrder { get; set; }

        public int fp_core_id { get; set; }
    }
}
