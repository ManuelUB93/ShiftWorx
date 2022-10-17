namespace ShiftWorx.Components.Responses
{
    public class ShiftResponse
    {
        public string message { get; set; }
        public List<Data_Shift> data { get; set; }
        public class Break_Shift
        {
            public int id { get; set; }
            public int shift_day_id { get; set; }
            public string name { get; set; }
            public int day { get; set; }
            public int start { get; set; }
            public int end { get; set; }
            public int created_at { get; set; }
            public int updated_at { get; set; }
            public object deleted_at { get; set; }
        }
        public class Data_Shift
        {
            public int shift_id { get; set; }
            public string shift_name { get; set; }
            public int shift_day_id { get; set; }
            public int shift_day_start { get; set; }
            public int shift_day_end { get; set; }
            public int shift_cycle_day_index { get; set; }
            public List<TimeRange_Shift> time_ranges { get; set; }
            public List<Break_Shift> breaks { get; set; }
            public bool crosses_midnight { get; set; }
        }
        public class TimeRange_Shift
        {
            public int start { get; set; }
            public int end { get; set; }
        }
    }
}
