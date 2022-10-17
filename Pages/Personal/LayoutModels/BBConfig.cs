namespace ShiftWorx.Pages.Personal.LayoutModels
{
    public class BBConfig
    {
        public string Name { get; set; }
        public BBSettings BBSettings { get; set; }
        public BBPlacement BBPlacement { get; set; }
    }
    public class BBSettings
    {
        public string name { get; set; }
        public object end_time { get; set; }
        public bool read_only { get; set; }
        public bool show_jobs { get; set; }
        public string range_type { get; set; }
        public bool show_alias { get; set; }
        public object start_time { get; set; }
        public bool show_operators { get; set; }
        public bool bluebar_enabled { get; set; }
        public List<object> selected_shifts { get; set; }
        public bool show_status_codes { get; set; }
        public string selected_shift_mode { get; set; }
        public List<int> selected_data_sources { get; set; }
        public int selected_activity_data_source { get; set; }
    }
    public class BBPlacement
    {
        public int h { get; set; }
        public int w { get; set; }
        public int x { get; set; }
        public int y { get; set; }
        public int minH { get; set; }
        public int minW { get; set; }
    }
}
