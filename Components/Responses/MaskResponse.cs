namespace ShiftWorx.Components.Responses
{
    public class MaskResponse
    {
        public class Data_Response
        {
            public List<object> state_mask { get; set; }
            public PreviousValue_Response previous_value { get; set; }
        }
        public class PreviousValue_Response
        {
            public int time { get; set; }
            public int state { get; set; }
        }
        public string message { get; set; }
        public Data_Response data { get; set; }
    }
}
