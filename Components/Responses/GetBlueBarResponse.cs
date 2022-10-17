public class GetBlueBarResponse
{
    public string message { get; set; }
    public Data_Bluebar data { get; set; }

    public class Data_Bluebar
    {
        public List<StateMask_Bluebar> state_mask { get; set; }
        public PreviousValue_Bluebar previous_value { get; set; }
    }
    public class PreviousValue_Bluebar
    {
        public int x { get; set; }
        public int y { get; set; }
    }
    public class StateMask_Bluebar
    {
        public int x { get; set; }
        public int y { get; set; }
    }
}
