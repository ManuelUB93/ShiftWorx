namespace ShiftWorx.Models
{
    public class Panel : LifeCycleEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Layout Layout { get; set; }
        public int LayoutId { get; set; }

        public PanelType? PanelType { get; set; }
        public int? PanelTypeId { get; set; }

        public string? Placement { get; set; }
        public string? Config { get; set; }

        public int fp_core_id { get; set; }

    }
}
