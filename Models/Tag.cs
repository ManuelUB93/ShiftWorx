namespace ShiftWorx.Models
{
    public class Tag: LifeCycleEntity
    {
        public int Id { get; set; }

        public Company Company { get; set; }
        public int CompanyId { get; set; }

        public string Name { get; set; }
        public TagType TagType { get; set; }
        public string Color { get; set; }
    }

    public enum TagType
    {
        DataSourceCollectors = 1, StatusCodeCollectors = 2, UserCollectors = 3, ReportLayoutCollectors = 4
    }
}
