namespace ShiftWorx.Components.Responses
{
    public class HasAccessResponse
    {
        public class Data_HasAccess
        {
            public string dsid { get; set; }
            public bool hasAccess { get; set; }
        }

        public string message { get; set; }
        public Data_HasAccess data { get; set; }


    }
}
