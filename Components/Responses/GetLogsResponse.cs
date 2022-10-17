namespace ShiftWorx.Components.Responses
{
    public class GetLogsResponse
    {
        public class Data_Logs
        {
            public List<Event_Logs> events { get; set; }
            public string page { get; set; }
            public int pages { get; set; }
        }

        public class Event_Logs
        {
            public int id { get; set; }
            public string user_id { get; set; }
            public int data_source_id { get; set; }
            public int product_id { get; set; }
            public int type_id { get; set; }
            public int created_at { get; set; }
            public string str_val { get; set; }
            public int created_at_timestamp { get; set; }
            public string user_name { get; set; }
            public string product_name { get; set; }
        }

            public string message { get; set; }
            public Data_Logs data { get; set; }
        

    }
}
