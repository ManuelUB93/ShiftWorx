namespace ShiftWorx.Models
{
    public class PanelPreviewInfo
    {
        public int Id { get; set; }
        public string PanelTypeKey { get; set; }
        public PanelTier PanelTier { get; set; }
        public string? PreviewImage { get; set; }
        public string? Description { get; set; }

        public int fp_core_id { get; set; }
    }

    public enum PanelTier
    {
        ShiftWorxLite = 1, ShiftWorxStandard = 2, ShiftWorxPlus = 3
    }
}
