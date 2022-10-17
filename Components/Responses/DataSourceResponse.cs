namespace ShiftWorx.Components.Responses
{
    public class DataSourceResponse
    {
        public class Data_DataSource
        {
            public DataSource_DataSource data_source { get; set; }
            public List<RunningJob_DataSource> running_jobs { get; set; }
            public List<object> running_operators { get; set; }
            public List<object> running_opcodes { get; set; }
        }
        public class DataSource_DataSource
        {
            public int id { get; set; }
            public int parent_id { get; set; }
            public int type_id { get; set; }
            public int primitive_type_id { get; set; }
            public int activity_definition_id { get; set; }
            public int filters_and_modifiers_id { get; set; }
            public string name { get; set; }
            public string desc { get; set; }
            public int is_active { get; set; }
            public int hidden { get; set; }
            public object num_val { get; set; }
            public object str_val { get; set; }
            public object json_val { get; set; }
            public object blob_val { get; set; }
            public int created_at { get; set; }
            public int updated_at { get; set; }
            public object deleted_at { get; set; }
            public string lineage_within_company_name { get; set; }
        }
        public string message { get; set; }
        public Data_DataSource data { get; set; }
        public class RunningJob_DataSource
        {
            public int id { get; set; }
            public int data_source_id { get; set; }
            public object parent_id { get; set; }
            public string name { get; set; }
            public string customer_name { get; set; }
            public string desc { get; set; }
            public int? target_count { get; set; }
            public int? target_runtime { get; set; }
            public int? runtime_scale_factor_id { get; set; }
            public int? target_runrate { get; set; }
            public int? runrate_scale_factor_id { get; set; }
            public int? est_start_date { get; set; }
            public string client_key { get; set; }
            public int? multiplier { get; set; }
            public object expected_cycle_time { get; set; }
            public object expected_cycle_time_deviation { get; set; }
            public int is_template { get; set; }
            public int is_open { get; set; }
            public int is_archived { get; set; }
            public int created_at { get; set; }
            public int updated_at { get; set; }
            public object deleted_at { get; set; }
            public object sort { get; set; }
            public int attached_at { get; set; }
            public int attachment_id { get; set; }
            public int attachment_job_id { get; set; }
            public int scrap_count { get; set; }
            public string lineage { get; set; }
        }
    }
}
