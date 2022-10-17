namespace ShiftWorx.Components.Responses
{
    public class ChangesResponse
    {
        public class Data_Changes
        {
            public List<object> state_mask { get; set; }
            public PreviousValue_Changes previous_value { get; set; }
        }
        public class PreviousValue_Changes
        {
            public int x { get; set; }
            public int y { get; set; }
        }
        public string message { get; set; }
        public Data_Changes data { get; set; }
    }
}
