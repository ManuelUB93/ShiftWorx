namespace ShiftWorx.Components.Responses
{
    public class SubscriptionsResponse
    {
        public class Data_Subs
        {
            public int id { get; set; }
            public int product_id { get; set; }
            public int hide { get; set; }
            public string product_name { get; set; }
            public string product_alias { get; set; }
            public int product_subscription_types_id { get; set; }
            public string subscription_type { get; set; }
            public int created_at { get; set; }
        }
        public string message { get; set; }
        public List<Data_Subs> data { get; set; }


    }
}
