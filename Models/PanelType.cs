namespace ShiftWorx.Models
{
    public class PanelType: LifeCycleEntity
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string Key { get; set; }
        public PanelCategory? Category { get; set; }
        public string? Notes { get; set; }
        public string? Description { get; set; }
        public string? MetaData { get; set; }
        public int VersionMajor { get; set; }
        public int VersionMinor { get; set; }
        public bool GlobalAccess { get; set; }

        public int fp_core_id { get; set; }
    }

    public enum PanelCategory
    {
        Visualization = 1, UserInput = 2, Reporting = 3, Management = 4
    }
}
