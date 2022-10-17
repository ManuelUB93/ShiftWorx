namespace ShiftWorx.Components.Responses
{
    public class RunningStatusCodesResponse
    {
        public class Data_RunningStatusCodes
        {
            public int id { get; set; }
            public int parent_id { get; set; }
            public int data_source_id { get; set; }
            public string name { get; set; }
            public string color { get; set; }
            public string reference_number { get; set; }
            public int created_at { get; set; }
            public int updated_at { get; set; }
            public object deleted_at { get; set; }
            public string root { get; set; }
            public int attached_at { get; set; }
            public int attachment_id { get; set; }
            public string lineage { get; set; }
        }


        public string message { get; set; }
        public List<Data_RunningStatusCodes> data { get; set; }

    }
}