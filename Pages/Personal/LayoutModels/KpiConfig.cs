namespace ShiftWorx.Pages.Personal.LayoutModels
{
    public class KpiConfig
    {
        public string Name { get; set; }
        public KpiSettings KpiSettings { get; set; }
        public KpiPlacement KpiPlacement { get; set; }

    }
    public class KpiSettings
    {
        public string bg_color { get; set; }
        public Threshold threshold { get; set; }
        public int selected_kpi { get; set; }
        public int refresh_rate_seconds { get; set; }
    }

    public class Threshold
    {
        public int value { get; set; }
        public string bg_color { get; set; }
        public string test_type { get; set; }
    }
    public class KpiPlacement
    {
        public int h { get; set; }
        public int w { get; set; }
        public int x { get; set; }
        public int y { get; set; }
        public int minH { get; set; }
        public int minW { get; set; }
    }
}
