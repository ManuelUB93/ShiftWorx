namespace ShiftWorx.Components.Responses
{
    public class LoginResponse
    {
        public string message { get; set; }
        public Data_Login data { get; set; }
        public class Data_Login
        {
            public string token { get; set; }
            public string userid { get; set; }
            public object user_image { get; set; }
        }
    }
}
