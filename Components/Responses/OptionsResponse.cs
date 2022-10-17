using static ShiftWorx.Components.Responses.StatusResponse;

namespace ShiftWorx.Components.Responses
{
    public class OptionsResponse
    {
        public class ClientKey_Options
        {
            public bool enabled { get; set; }
            public bool required { get; set; }
            public object @default { get; set; }
        }

        public class CustomerName_Options
        {
            public bool enabled { get; set; }
            public bool required { get; set; }
            public object @default { get; set; }
        }

        public class CustomScheduledCTDeviationReport10_Options
        {
            public int selected_interval_seconds { get; set; }
            public bool report_paused { get; set; }
            public object recipient_address { get; set; }
        }

        public class CustomScheduledStatusCodeReport10_Options
        {
            public List<object> selected_code_ids { get; set; }
            public int selected_interval_seconds { get; set; }
            public bool report_paused { get; set; }
            public object recipient_address { get; set; }
        }

        public class Data_Options
        {
            public string timezone { get; set; }
            public string locale { get; set; }
            public string lang { get; set; }
            public bool use_meridiem { get; set; }
            public VaaOptions_Options vaa_options { get; set; }
            public JobFields_Options job_fields { get; set; }
            public List<object> dictionary_keyword_overrides { get; set; }
            public CustomScheduledStatusCodeReport10_Options CustomScheduledStatusCodeReport10 { get; set; }
            public CustomScheduledCTDeviationReport10_Options CustomScheduledCTDeviationReport10 { get; set; }
        }

        public class Desc_Options
        {
            public bool enabled { get; set; }
            public bool required { get; set; }
            public object @default { get; set; }
        }

        public class EstStartDate_Options
        {
            public bool enabled { get; set; }
            public bool required { get; set; }
            public object @default { get; set; }
        }

        public class ExpectedCycleTime_Options
        {
            public bool enabled { get; set; }
            public bool required { get; set; }
            public object @default { get; set; }
        }

        public class ExpectedCycleTimeDeviation_Options
        {
            public bool enabled { get; set; }
            public bool required { get; set; }
            public int @default { get; set; }
        }

        public class JobFields_Options
        {
            public Desc_Options desc { get; set; }
            public TargetCount_Options target_count { get; set; }
            public Multiplier_Options multiplier { get; set; }
            public ExpectedCycleTime_Options expected_cycle_time { get; set; }
            public ExpectedCycleTimeDeviation_Options expected_cycle_time_deviation { get; set; }
            public CustomerName_Options customer_name { get; set; }
            public ClientKey_Options client_key { get; set; }
            public TargetRunrate_Options target_runrate { get; set; }
            public TargetRuntime_Options target_runtime { get; set; }
            public EstStartDate_Options est_start_date { get; set; }
        }

        public class Multiplier_Options
        {
            public bool enabled { get; set; }
            public bool required { get; set; }
            public int @default { get; set; }
        }
        public string message { get; set; }
        public Data_Options data { get; set; }
        public class TargetCount_Options
        {
            public bool enabled { get; set; }
            public bool required { get; set; }
            public object @default { get; set; }
        }

        public class TargetRunrate_Options
        {
            public bool enabled { get; set; }
            public bool required { get; set; }
            public object @default { get; set; }
        }

        public class TargetRuntime_Options
        {
            public bool enabled { get; set; }
            public bool required { get; set; }
            public object @default { get; set; }
        }

        public class VaaOptions_Options
        {
            public int min_on_filter { get; set; }
            public int min_off_filter { get; set; }
            public int min_on_modifier { get; set; }
            public int max_on_modifier { get; set; }
        }
    }
}