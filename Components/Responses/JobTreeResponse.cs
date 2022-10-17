namespace ShiftWorx.Components.Responses
{
    public class JobTreeResponse
    {
        public class Data_JobTree
        {
            public int id { get; set; }
            public object parent_id { get; set; }
            public int data_source_id { get; set; }
            public string name { get; set; }
            public string desc { get; set; }
            public int? target_count { get; set; }
            public int? est_start_date { get; set; }
            public int is_template { get; set; }
            public int is_open { get; set; }
            public int is_archived { get; set; }
            public string client_key { get; set; }
            public int? multiplier { get; set; }
            public object expected_cycle_time { get; set; }
            public object expected_cycle_time_deviation { get; set; }
            public int? target_runrate { get; set; }
            public int? runrate_scale_factor_id { get; set; }
            public int? target_runtime { get; set; }
            public int? runtime_scale_factor_id { get; set; }
            public List<object> customFields { get; set; }
            public List<object> customFieldAttachments { get; set; }
            public List<object> children { get; set; }
        }

     
            public string message { get; set; }
            public List<Data_JobTree> data { get; set; }
      
    }
}
