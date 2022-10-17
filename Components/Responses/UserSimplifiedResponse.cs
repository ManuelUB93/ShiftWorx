namespace ShiftWorx.Components.Responses
{
    public class UserSimplifiedResponse
    {
        public class CurrentAttachment_UserSimplified
        {
            public int id { get; set; }
            public int data_source_id { get; set; }
            public int type_id { get; set; }
            public int user_id { get; set; }
            public object job_id { get; set; }
            public object opcode_id { get; set; }
            public object sort { get; set; }
            public int attached_at { get; set; }
            public object detached_at { get; set; }
            public int created_at { get; set; }
            public int updated_at { get; set; }
            public object deleted_at { get; set; }
        }

        public class Data_UserSimplified
        {
            public string id { get; set; }
            public string username { get; set; }
            public string display_name { get; set; }
            public string badge_number { get; set; }
            public string reference_number { get; set; }
            public object color { get; set; }
            public List<CurrentAttachment_UserSimplified> current_attachments { get; set; }
            public int is_attached { get; set; }
        }


            public string message { get; set; }
            public List<Data_UserSimplified> data { get; set; }
        
    }
}
