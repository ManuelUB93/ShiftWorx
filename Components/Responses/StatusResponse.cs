namespace ShiftWorx.Components.Responses
{
    public class StatusResponse
    {
        public string message { get; set; }
        public Data_status data { get; set; }
    }

    public class Data_status
    {
        public User user { get; set; }
        public Company[] companies { get; set; }
        public Product_Access product_access { get; set; }
        public Feature_Permissions feature_permissions { get; set; }
        public object[] job_tree { get; set; }
        public Opcodes_Tree[] opcodes_tree { get; set; }
        public Active_Operators[] active_operators { get; set; }
        public Scrap_Types[] scrap_types { get; set; }
        public Company_Options company_options { get; set; }
        public Panel_Types[] panel_types { get; set; }
        public Layout[] layouts { get; set; }
        public object default_layout { get; set; }
        public Shift2[] shifts { get; set; }
        public int[] dsids_with_work_def_descendants { get; set; }
        public Report_Range_Types[] report_range_types { get; set; }
        public Data_Source_Types[] data_source_types { get; set; }
        public Panel_Tiers[] panel_tiers { get; set; }
        public Panels_Preview_Info[] panels_preview_info { get; set; }
        public Timescale_Factors[] timescale_factors { get; set; }
        public Value_Types[] value_types { get; set; }
        public Report_Sub_Types[] report_sub_types { get; set; }
        public Calculation_Window_Transition_Types[] calculation_window_transition_types { get; set; }
        public Chart_Types[] chart_types { get; set; }
        public Tick_Rate_Types[] tick_rate_types { get; set; }
        public Math_Types[] math_types { get; set; }
    }

    public class User
    {
        public string id { get; set; }
        public string username { get; set; }
        public string display_name { get; set; }
        public string first_name { get; set; }
        public int data_source_id { get; set; }
        public string last_name { get; set; }
        public string cellphone { get; set; }
        public int created_at { get; set; }
        public int updated_at { get; set; }
        public object deleted_at { get; set; }
        public string email { get; set; }
        public string reference_number { get; set; }
        public int new_password { get; set; }
        public int is_active { get; set; }
        public int role_id { get; set; }
        public int account_type_id { get; set; }
        public object image { get; set; }
        public string badge_number { get; set; }
        public string job_title { get; set; }
        public object color { get; set; }
        public int has_set_up_account { get; set; }
        public int is_pseudo_user { get; set; }
        public Admin_Role[] admin_role { get; set; }
        public int admin_roles { get; set; }
        public bool is_freepoint_user { get; set; }
    }

    public class Admin_Role
    {
        public int id { get; set; }
        public string name { get; set; }
        public int data_source_id { get; set; }
        public int is_hidden { get; set; }
        public int is_locked { get; set; }
        public int created_at { get; set; }
        public int updated_at { get; set; }
        public object deleted_at { get; set; }
    }

    public class Product_Access
    {
        public Legacy_Watch_Live legacy_watch_live { get; set; }
        public Narrative narrative { get; set; }
        public Notifications notifications { get; set; }
        public Scheduler scheduler { get; set; }
        public Process_Analyser process_analyser { get; set; }
        public Administration_Settings administration_settings { get; set; }
        public Product_Documentation product_documentation { get; set; }
        public Freepoint_Publications freepoint_publications { get; set; }
        public User_Profile user_profile { get; set; }
        public Dashboard dashboard { get; set; }
        public Watch_Live watch_live { get; set; }
        public Job_Manager job_manager { get; set; }
        public Core core { get; set; }
        public Remote_Firmware remote_firmware { get; set; }
        public Freepoint_Connect_Ui freepoint_connect_ui { get; set; }
        public Freepoint_Connect_Server freepoint_connect_server { get; set; }
        public Shiftworx shiftworx { get; set; }
        public Public_Api public_api { get; set; }
    }

    public class Legacy_Watch_Live
    {
        public int product_id { get; set; }
        public int access_level { get; set; }
        public string access_level_name { get; set; }
    }

    public class Narrative
    {
        public int product_id { get; set; }
        public int access_level { get; set; }
        public string access_level_name { get; set; }
    }

    public class Notifications
    {
        public int product_id { get; set; }
        public int access_level { get; set; }
        public string access_level_name { get; set; }
    }

    public class Scheduler
    {
        public int product_id { get; set; }
        public int access_level { get; set; }
        public string access_level_name { get; set; }
    }

    public class Process_Analyser
    {
        public int product_id { get; set; }
        public int access_level { get; set; }
        public string access_level_name { get; set; }
    }

    public class Administration_Settings
    {
        public int product_id { get; set; }
        public int access_level { get; set; }
        public string access_level_name { get; set; }
    }

    public class Product_Documentation
    {
        public int product_id { get; set; }
        public int access_level { get; set; }
        public string access_level_name { get; set; }
    }

    public class Freepoint_Publications
    {
        public int product_id { get; set; }
        public int access_level { get; set; }
        public string access_level_name { get; set; }
    }

    public class User_Profile
    {
        public int product_id { get; set; }
        public int access_level { get; set; }
        public string access_level_name { get; set; }
    }

    public class Dashboard
    {
        public int product_id { get; set; }
        public int access_level { get; set; }
        public string access_level_name { get; set; }
    }

    public class Watch_Live
    {
        public int product_id { get; set; }
        public int access_level { get; set; }
        public string access_level_name { get; set; }
    }

    public class Job_Manager
    {
        public int product_id { get; set; }
        public int access_level { get; set; }
        public string access_level_name { get; set; }
    }

    public class Core
    {
        public int product_id { get; set; }
        public int access_level { get; set; }
        public string access_level_name { get; set; }
    }

    public class Remote_Firmware
    {
        public int product_id { get; set; }
        public int access_level { get; set; }
        public string access_level_name { get; set; }
    }

    public class Freepoint_Connect_Ui
    {
        public int product_id { get; set; }
        public int access_level { get; set; }
        public string access_level_name { get; set; }
    }

    public class Freepoint_Connect_Server
    {
        public int product_id { get; set; }
        public int access_level { get; set; }
        public string access_level_name { get; set; }
    }

    public class Shiftworx
    {
        public int product_id { get; set; }
        public int access_level { get; set; }
        public string access_level_name { get; set; }
    }

    public class Public_Api
    {
        public int product_id { get; set; }
        public int access_level { get; set; }
        public string access_level_name { get; set; }
    }

    public class Feature_Permissions
    {
        public Legacy_Watch_Live1[] legacy_watch_live { get; set; }
        public Narrative1[] narrative { get; set; }
        public Scheduler1[] scheduler { get; set; }
        public Administration_Settings1[] administration_settings { get; set; }
        public Modular_Narrative[] modular_narrative { get; set; }
        public Shiftworx1[] shiftworx { get; set; }
    }

    public class Legacy_Watch_Live1
    {
        public int id { get; set; }
        public int enabled { get; set; }
        public string feature_permission { get; set; }
        public int product_id { get; set; }
    }

    public class Narrative1
    {
        public int id { get; set; }
        public int enabled { get; set; }
        public string feature_permission { get; set; }
        public int product_id { get; set; }
    }

    public class Scheduler1
    {
        public int id { get; set; }
        public int enabled { get; set; }
        public string feature_permission { get; set; }
        public int product_id { get; set; }
    }

    public class Administration_Settings1
    {
        public int id { get; set; }
        public int enabled { get; set; }
        public string feature_permission { get; set; }
        public int product_id { get; set; }
    }

    public class Modular_Narrative
    {
        public int id { get; set; }
        public int enabled { get; set; }
        public string feature_permission { get; set; }
        public int product_id { get; set; }
    }

    public class Shiftworx1
    {
        public int id { get; set; }
        public int enabled { get; set; }
        public string feature_permission { get; set; }
        public int product_id { get; set; }
    }

    public class Company_Options
    {
        public string timezone { get; set; }
        public string locale { get; set; }
        public string lang { get; set; }
        public bool use_meridiem { get; set; }
        public Vaa_Options vaa_options { get; set; }
        public Job_Fields job_fields { get; set; }
        public object[] dictionary_keyword_overrides { get; set; }
        public Customscheduledstatuscodereport10 CustomScheduledStatusCodeReport10 { get; set; }
        public Customscheduledctdeviationreport10 CustomScheduledCTDeviationReport10 { get; set; }
        public int editable_time_limit { get; set; }
    }

    public class Vaa_Options
    {
        public int min_on_filter { get; set; }
        public int min_off_filter { get; set; }
        public int min_on_modifier { get; set; }
        public int max_on_modifier { get; set; }
    }

    public class Job_Fields
    {
        public Desc desc { get; set; }
        public Target_Count target_count { get; set; }
        public Multiplier multiplier { get; set; }
        public Expected_Cycle_Time expected_cycle_time { get; set; }
        public Expected_Cycle_Time_Deviation expected_cycle_time_deviation { get; set; }
        public Customer_Name customer_name { get; set; }
        public Client_Key client_key { get; set; }
        public Target_Runrate target_runrate { get; set; }
        public Target_Runtime target_runtime { get; set; }
        public Est_Start_Date est_start_date { get; set; }
        public Planned_End_Date planned_end_date { get; set; }
        public Preferred_Data_Sources preferred_data_sources { get; set; }
    }

    public class Desc
    {
        public bool enabled { get; set; }
        public bool required { get; set; }
        public object _default { get; set; }
    }

    public class Target_Count
    {
        public bool enabled { get; set; }
        public bool required { get; set; }
        public object _default { get; set; }
    }

    public class Multiplier
    {
        public bool enabled { get; set; }
        public bool required { get; set; }
        public object _default { get; set; }
    }

    public class Expected_Cycle_Time
    {
        public bool enabled { get; set; }
        public bool required { get; set; }
        public object _default { get; set; }
    }

    public class Expected_Cycle_Time_Deviation
    {
        public bool enabled { get; set; }
        public bool required { get; set; }
        public int _default { get; set; }
    }

    public class Customer_Name
    {
        public bool enabled { get; set; }
        public bool required { get; set; }
        public object _default { get; set; }
    }

    public class Client_Key
    {
        public bool enabled { get; set; }
        public bool required { get; set; }
        public object _default { get; set; }
    }

    public class Target_Runrate
    {
        public bool enabled { get; set; }
        public bool required { get; set; }
        public object _default { get; set; }
    }

    public class Target_Runtime
    {
        public bool enabled { get; set; }
        public bool required { get; set; }
        public object _default { get; set; }
    }

    public class Est_Start_Date
    {
        public bool enabled { get; set; }
        public bool required { get; set; }
        public object _default { get; set; }
    }

    public class Planned_End_Date
    {
        public bool enabled { get; set; }
        public bool required { get; set; }
        public object _default { get; set; }
    }

    public class Preferred_Data_Sources
    {
        public bool enabled { get; set; }
        public bool required { get; set; }
    }

    public class Customscheduledstatuscodereport10
    {
        public object[] selected_code_ids { get; set; }
        public int selected_interval_seconds { get; set; }
        public bool report_paused { get; set; }
        public object recipient_address { get; set; }
    }

    public class Customscheduledctdeviationreport10
    {
        public int selected_interval_seconds { get; set; }
        public bool report_paused { get; set; }
        public object recipient_address { get; set; }
    }

    public class Company
    {
        public int id { get; set; }
        public int? parent_id { get; set; }
        public int type_id { get; set; }
        public object primitive_type_id { get; set; }
        public object activity_definition_id { get; set; }
        public int? filters_and_modifiers_id { get; set; }
        public string name { get; set; }
        public string desc { get; set; }
        public int is_active { get; set; }
        public int hidden { get; set; }
        public object num_val { get; set; }
        public string str_val { get; set; }
        public object json_val { get; set; }
        public string blob_val { get; set; }
        public int created_at { get; set; }
        public int updated_at { get; set; }
        public object deleted_at { get; set; }
        public object lineage_within_company_name { get; set; }
    }

    public class Opcodes_Tree
    {
        public int id { get; set; }
        public object parent_id { get; set; }
        public int data_source_id { get; set; }
        public string name { get; set; }
        public string color { get; set; }
        public object reference_number { get; set; }
        public object deleted_at { get; set; }
        public Child[] children { get; set; }
        public string root { get; set; }
        public int value { get; set; }
        public string label { get; set; }
        public string lineage { get; set; }
    }

    public class Child
    {
        public int id { get; set; }
        public int parent_id { get; set; }
        public int data_source_id { get; set; }
        public string name { get; set; }
        public string color { get; set; }
        public object reference_number { get; set; }
        public object deleted_at { get; set; }
        public Child1[] children { get; set; }
        public string root { get; set; }
        public int value { get; set; }
        public string label { get; set; }
        public string lineage { get; set; }
        public int level { get; set; }
    }

    public class Child1
    {
        public int id { get; set; }
        public int parent_id { get; set; }
        public int data_source_id { get; set; }
        public string name { get; set; }
        public string color { get; set; }
        public string reference_number { get; set; }
        public object deleted_at { get; set; }
        public object[] children { get; set; }
        public string root { get; set; }
        public int value { get; set; }
        public string label { get; set; }
        public string lineage { get; set; }
        public int level { get; set; }
    }

    public class Active_Operators
    {
        public string id { get; set; }
        public string username { get; set; }
        public string display_name { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public int is_active { get; set; }
        public string email { get; set; }
        public string job_title { get; set; }
        public string badge_number { get; set; }
        public string cellphone { get; set; }
        public object image { get; set; }
        public string reference_number { get; set; }
        public int has_set_up_account { get; set; }
        public int is_pseudo_user { get; set; }
        public object color { get; set; }
        public int role_id { get; set; }
        public string role_name { get; set; }
        public Default_Layout default_layout { get; set; }
        public Data_Sources[] data_sources { get; set; }
        public int is_attached { get; set; }
        public int reset_token_exists { get; set; }
    }

    public class Default_Layout
    {
        public int id { get; set; }
        public string name { get; set; }
    }

    public class Data_Sources
    {
        public int id { get; set; }
        public int parent_id { get; set; }
        public int type_id { get; set; }
        public object primitive_type_id { get; set; }
        public object activity_definition_id { get; set; }
        public int filters_and_modifiers_id { get; set; }
        public string name { get; set; }
        public object desc { get; set; }
        public int is_active { get; set; }
        public int hidden { get; set; }
        public object num_val { get; set; }
        public string str_val { get; set; }
        public object json_val { get; set; }
        public string blob_val { get; set; }
        public int created_at { get; set; }
        public int updated_at { get; set; }
        public object deleted_at { get; set; }
        public object lineage_within_company_name { get; set; }
    }

    public class Scrap_Types
    {
        public int id { get; set; }
        public int data_source_id { get; set; }
        public string name { get; set; }
        public string reference_number { get; set; }
        public int created_at { get; set; }
        public int updated_at { get; set; }
        public object deleted_at { get; set; }
    }

    public class Panel_Types
    {
        public int id { get; set; }
        public string name { get; set; }
        public string key { get; set; }
        public int? category_id { get; set; }
        public string notes { get; set; }
        public object description { get; set; }
        public Metadata metadata { get; set; }
        public int version_major { get; set; }
        public int version_minor { get; set; }
        public int global_access { get; set; }
        public int created_at { get; set; }
        public int updated_at { get; set; }
        public object deleted_at { get; set; }
        public string version_number { get; set; }
    }

    public class Metadata
    {
        public int? maxH { get; set; }
        public int? maxW { get; set; }
        public int minH { get; set; }
        public int minW { get; set; }
        public Blankconfig blankConfig { get; set; }
        public bool requiresActivityDataSource { get; set; }
    }

    public class Blankconfig
    {
        public string name { get; set; }
        public object end_time { get; set; }
        public bool read_only { get; set; }
        public bool show_jobs { get; set; }
        public string range_type { get; set; }
        public bool show_alias { get; set; }
        public bool show_shift { get; set; }
        public object start_time { get; set; }
        public bool show_operators { get; set; }
        public bool bluebar_enabled { get; set; }
        public object[] selected_shifts { get; set; }
        public bool show_status_codes { get; set; }
        public string selected_shift_mode { get; set; }
        public object refresh_rate_minutes { get; set; }
        public object[] selected_data_sources { get; set; }
        public bool show_connection_status { get; set; }
        public object selected_activity_data_source { get; set; }
        public object selected_connection_status_data_source { get; set; }
        public string bg_color { get; set; }
        public Threshold threshold { get; set; }
        public Threshold_2 threshold_2 { get; set; }
        public object display_type { get; set; }
        public Selected_Kpi selected_kpi { get; set; }
        public string decimal_places { get; set; }
        public bool hide_kpi_value { get; set; }
        public Display_Type_Opts display_type_opts { get; set; }
        public int refresh_rate_seconds { get; set; }
        public string chart_color { get; set; }
        public object target_value { get; set; }
        public object y_axis_title { get; set; }
        public bool show_bar_value { get; set; }
        public Selected_Report selected_report { get; set; }
        public bool show_average_line { get; set; }
        public object color { get; set; }
        public string message { get; set; }
        public object alert_id { get; set; }
        public object[] recipients { get; set; }
        public object report_definition_id { get; set; }
        public object[] selected_status_code { get; set; }
        public object[] selected_status_code_data_sources { get; set; }
        public Date_Range date_range { get; set; }
        public object selected_shift { get; set; }
        public object data_type { get; set; }
        public bool barcode_mode { get; set; }
        public int range_limit { get; set; }
        public bool hide_uptime { get; set; }
        public bool force_opcode_selection { get; set; }
        public bool force_job_selection { get; set; }
        public Jobs jobs { get; set; }
        public Notes notes { get; set; }
        public Scrap scrap { get; set; }
        public Operators operators { get; set; }
        public bool zoom_enabled { get; set; }
        public Operation_Codes operation_codes { get; set; }
        public int duration_seconds { get; set; }
        public bool show_attachment_type_labels { get; set; }
    }

    public class Threshold
    {
        public object ceds { get; set; }
        public object value { get; set; }
        public string bg_color { get; set; }
        public string test_type { get; set; }
        public string value_type { get; set; }
    }

    public class Threshold_2
    {
        public object ceds { get; set; }
        public object value { get; set; }
        public string bg_color { get; set; }
        public object test_type { get; set; }
        public string value_type { get; set; }
    }

    public class Selected_Kpi
    {
        public object id { get; set; }
        public string name { get; set; }
        public object color { get; set; }
        public object[] shifts { get; set; }
        public string suffix { get; set; }
        public int type_id { get; set; }
        public bool all_shifts { get; set; }
        public bool shift_based { get; set; }
        public object sub_type_id { get; set; }
        public object[] data_sources { get; set; }
        public object static_result { get; set; }
        public object value_type_id { get; set; }
        public bool active_shift_based { get; set; }
        public object rolling_calculation_window { get; set; }
        public object semi_fixed_calculation_window { get; set; }
        public object[] narration_primitive_data_source_pairings { get; set; }
    }

    public class Display_Type_Opts
    {
        public object max { get; set; }
        public object min { get; set; }
    }

    public class Selected_Report
    {
        public object id { get; set; }
        public object[] jobs { get; set; }
        public string name { get; set; }
        public object color { get; set; }
        public object[] users { get; set; }
        public int offset { get; set; }
        public object[] shifts { get; set; }
        public string suffix { get; set; }
        public int divisor { get; set; }
        public object[] opcodes { get; set; }
        public int type_id { get; set; }
        public object end_time { get; set; }
        public object tick_rate { get; set; }
        public bool all_shifts { get; set; }
        public object start_time { get; set; }
        public object[] scrap_types { get; set; }
        public bool shift_based { get; set; }
        public object sub_type_id { get; set; }
        public object[] data_sources { get; set; }
        public object math_type_id { get; set; }
        public bool scrap_adjust { get; set; }
        public object chart_type_id { get; set; }
        public object value_type_id { get; set; }
        public object tick_rate_type_id { get; set; }
        public object time_step_seconds { get; set; }
        public int transition_type_id { get; set; }
        public object window_size_seconds { get; set; }
        public object report_range_type_id { get; set; }
        public object[] narration_primitive_data_source_pairings { get; set; }
    }

    public class Date_Range
    {
        public object end { get; set; }
        public object start { get; set; }
    }

    public class Jobs
    {
        public bool entry_enabled { get; set; }
        public bool timeline_enabled { get; set; }
    }

    public class Notes
    {
        public bool entry_enabled { get; set; }
        public bool timeline_enabled { get; set; }
    }

    public class Scrap
    {
        public bool entry_enabled { get; set; }
        public bool timeline_enabled { get; set; }
        public bool force_job_selection { get; set; }
    }

    public class Operators
    {
        public bool entry_enabled { get; set; }
        public bool timeline_enabled { get; set; }
    }

    public class Operation_Codes
    {
        public bool entry_enabled { get; set; }
        public bool timeline_enabled { get; set; }
    }

    public class Layout
    {
        public int id { get; set; }
        public int product_id { get; set; }
        public int creator_user_id { get; set; }
        public int company_id { get; set; }
        public string name { get; set; }
        public int is_reporting { get; set; }
        public int created_at { get; set; }
        public int updated_at { get; set; }
        public string username { get; set; }
        public PanelStatus[] panels { get; set; }
    }

    public class PanelStatus
    {
        public int id { get; set; }
        public int type_id { get; set; }
        public int layout_id { get; set; }
        public string name { get; set; }
        public Placement placement { get; set; }
        public Config config { get; set; }
        public int created_at { get; set; }
        public int updated_at { get; set; }
        public Panel_Type panel_type { get; set; }
    }

    public class Placement
    {
        public int h { get; set; }
        public int w { get; set; }
        public int x { get; set; }
        public int y { get; set; }
        public int minH { get; set; }
        public int minW { get; set; }
    }

    public class Config
    {
        public string name { get; set; }
        public object end_time { get; set; }
        public bool read_only { get; set; }
        public bool show_jobs { get; set; }
        public string range_type { get; set; }
        public bool show_alias { get; set; }
        public bool show_shift { get; set; }
        public object start_time { get; set; }
        public bool show_operators { get; set; }
        public bool bluebar_enabled { get; set; }
        public object[] selected_shifts { get; set; }
        public bool show_status_codes { get; set; }
        public string selected_shift_mode { get; set; }
        public object refresh_rate_minutes { get; set; }
        public Selected_Data_Sources[] selected_data_sources { get; set; }
        public Selected_Activity_Data_Source selected_activity_data_source { get; set; }
        public string bg_color { get; set; }
        public Threshold1 threshold { get; set; }
        public Threshold_21 threshold_2 { get; set; }
        public Selected_Kpi1 selected_kpi { get; set; }
        public int refresh_rate_seconds { get; set; }
        public Jobs1 jobs { get; set; }
        public Notes1 notes { get; set; }
        public Scrap1 scrap { get; set; }
        public Operators1 operators { get; set; }
        public bool zoom_enabled { get; set; }
        public Operation_Codes1 operation_codes { get; set; }
        public int duration_seconds { get; set; }
        public bool show_connection_status { get; set; }
        public bool show_attachment_type_labels { get; set; }
        public object selected_connection_status_data_source { get; set; }
        public int max_activity_duration { get; set; }
        public int min_activity_duration { get; set; }
        public string chart_color { get; set; }
        public int? target_value { get; set; }
        public object y_axis_title { get; set; }
        public bool show_bar_value { get; set; }
        public Selected_Report1 selected_report { get; set; }
        public bool show_average_line { get; set; }
    }

    public class Selected_Activity_Data_Source
    {
        public int id { get; set; }
        public int parent_id { get; set; }
        public int type_id { get; set; }
        public int primitive_type_id { get; set; }
        public int activity_definition_id { get; set; }
        public int? filters_and_modifiers_id { get; set; }
        public string name { get; set; }
        public string desc { get; set; }
        public int is_active { get; set; }
        public int hidden { get; set; }
        public object num_val { get; set; }
        public object str_val { get; set; }
        public object json_val { get; set; }
        public object blob_val { get; set; }
        public int created_at { get; set; }
        public int updated_at { get; set; }
        public object deleted_at { get; set; }
        public string lineage_within_company_name { get; set; }
        public Parent_Data_Source parent_data_source { get; set; }
    }

    public class Parent_Data_Source
    {
        public int id { get; set; }
        public string name { get; set; }
        public string lineage_within_company_name { get; set; }
    }

    public class Threshold1
    {
        public int? value { get; set; }
        public string bg_color { get; set; }
        public string test_type { get; set; }
    }

    public class Threshold_21
    {
        public int? value { get; set; }
        public string bg_color { get; set; }
        public string test_type { get; set; }
    }

    public class Selected_Kpi1
    {
        public int id { get; set; }
        public int company_id { get; set; }
        public int type_id { get; set; }
        public int sub_type_id { get; set; }
        public int value_type_id { get; set; }
        public object transition_type_id { get; set; }
        public object report_range_type_id { get; set; }
        public object chart_type_id { get; set; }
        public object tick_rate_type_id { get; set; }
        public object math_type_id { get; set; }
        public object fixed_cw_id { get; set; }
        public int? semi_fixed_cw_id { get; set; }
        public int? rolling_cw_id { get; set; }
        public string name { get; set; }
        public string suffix { get; set; }
        public object color { get; set; }
        public string static_result { get; set; }
        public int divisor { get; set; }
        public object tick_rate { get; set; }
        public int scrap_adjust { get; set; }
        public bool shift_based { get; set; }
        public bool active_shift_based { get; set; }
        public object start_time { get; set; }
        public object end_time { get; set; }
        public object time_step_seconds { get; set; }
        public int offset { get; set; }
        public object window_size_seconds { get; set; }
        public int created_at { get; set; }
        public int created_by { get; set; }
        public int updated_at { get; set; }
        public int updated_by { get; set; }
        public object deleted_at { get; set; }
        public Semi_Fixed_Calculation_Window semi_fixed_calculation_window { get; set; }
        public Rolling_Calculation_Window rolling_calculation_window { get; set; }
        public Shift[] shifts { get; set; }
        public Data_Sources1[] data_sources { get; set; }
        public object[] narration_primitive_data_source_pairings { get; set; }
    }

    public class Semi_Fixed_Calculation_Window
    {
        public int id { get; set; }
        public int transition_type_id { get; set; }
        public int offset { get; set; }
        public object time_step_seconds { get; set; }
        public int created_at { get; set; }
        public int updated_at { get; set; }
    }

    public class Rolling_Calculation_Window
    {
        public int id { get; set; }
        public int window_size_seconds { get; set; }
        public int created_at { get; set; }
        public int updated_at { get; set; }
    }

    public class Shift
    {
        public int id { get; set; }
        public string name { get; set; }
    }

    public class Data_Sources1
    {
        public int id { get; set; }
        public int parent_id { get; set; }
        public string name { get; set; }
        public int type_id { get; set; }
        public object blob_val { get; set; }
        public string lineage_within_company_name { get; set; }
        public Pivot pivot { get; set; }
        public Lineage_Within_Company lineage_within_company { get; set; }
    }

    public class Pivot
    {
        public int report_id { get; set; }
        public int data_source_id { get; set; }
    }

    public class Lineage_Within_Company
    {
        public int id { get; set; }
        public int parent_id { get; set; }
        public string name { get; set; }
        public string lineage_within_company_name { get; set; }
        public Lineage_Within_Company1 lineage_within_company { get; set; }
    }

    public class Lineage_Within_Company1
    {
        public int id { get; set; }
        public int parent_id { get; set; }
        public string name { get; set; }
        public string lineage_within_company_name { get; set; }
        public object lineage_within_company { get; set; }
    }

    public class Jobs1
    {
        public bool entry_enabled { get; set; }
        public bool timeline_enabled { get; set; }
    }

    public class Notes1
    {
        public bool entry_enabled { get; set; }
        public bool timeline_enabled { get; set; }
    }

    public class Scrap1
    {
        public bool entry_enabled { get; set; }
        public bool timeline_enabled { get; set; }
        public bool force_job_selection { get; set; }
    }

    public class Operators1
    {
        public bool entry_enabled { get; set; }
        public bool timeline_enabled { get; set; }
    }

    public class Operation_Codes1
    {
        public bool entry_enabled { get; set; }
        public bool timeline_enabled { get; set; }
    }

    public class Selected_Report1
    {
        public int id { get; set; }
        public int company_id { get; set; }
        public int type_id { get; set; }
        public int sub_type_id { get; set; }
        public int value_type_id { get; set; }
        public int? transition_type_id { get; set; }
        public int report_range_type_id { get; set; }
        public int chart_type_id { get; set; }
        public int? tick_rate_type_id { get; set; }
        public object math_type_id { get; set; }
        public object fixed_cw_id { get; set; }
        public object semi_fixed_cw_id { get; set; }
        public object rolling_cw_id { get; set; }
        public string name { get; set; }
        public object suffix { get; set; }
        public object color { get; set; }
        public object static_result { get; set; }
        public int divisor { get; set; }
        public int? tick_rate { get; set; }
        public int scrap_adjust { get; set; }
        public bool shift_based { get; set; }
        public bool active_shift_based { get; set; }
        public int? start_time { get; set; }
        public int? end_time { get; set; }
        public object time_step_seconds { get; set; }
        public int? offset { get; set; }
        public object window_size_seconds { get; set; }
        public int created_at { get; set; }
        public int created_by { get; set; }
        public int updated_at { get; set; }
        public int updated_by { get; set; }
        public object deleted_at { get; set; }
        public Shift1[] shifts { get; set; }
        public Data_Sources2[] data_sources { get; set; }
        public object[] narration_primitive_data_source_pairings { get; set; }
        public object[] jobs { get; set; }
        public object[] opcodes { get; set; }
        public object[] users { get; set; }
        public object[] scrap_types { get; set; }
    }

    public class Shift1
    {
        public int id { get; set; }
        public string name { get; set; }
    }

    public class Data_Sources2
    {
        public int id { get; set; }
        public int parent_id { get; set; }
        public string name { get; set; }
        public int type_id { get; set; }
        public object blob_val { get; set; }
        public string lineage_within_company_name { get; set; }
        public Pivot1 pivot { get; set; }
    }

    public class Pivot1
    {
        public int report_id { get; set; }
        public int data_source_id { get; set; }
    }

    public class Selected_Data_Sources
    {
        public int id { get; set; }
        public int parent_id { get; set; }
        public int type_id { get; set; }
        public int? primitive_type_id { get; set; }
        public int? activity_definition_id { get; set; }
        public int? filters_and_modifiers_id { get; set; }
        public string name { get; set; }
        public string desc { get; set; }
        public int is_active { get; set; }
        public int hidden { get; set; }
        public int? num_val { get; set; }
        public string str_val { get; set; }
        public object json_val { get; set; }
        public object blob_val { get; set; }
        public int created_at { get; set; }
        public int updated_at { get; set; }
        public object deleted_at { get; set; }
        public string lineage_within_company_name { get; set; }
        public Parent_Data_Source1 parent_data_source { get; set; }
    }

    public class Parent_Data_Source1
    {
        public int id { get; set; }
        public string name { get; set; }
        public string lineage_within_company_name { get; set; }
    }

    public class Panel_Type
    {
        public int id { get; set; }
        public string name { get; set; }
        public string key { get; set; }
        public int category_id { get; set; }
        public string notes { get; set; }
        public object description { get; set; }
        public Metadata1 metadata { get; set; }
        public int version_major { get; set; }
        public int version_minor { get; set; }
        public int global_access { get; set; }
        public int created_at { get; set; }
        public int updated_at { get; set; }
        public object deleted_at { get; set; }
        public string version_number { get; set; }
    }

    public class Metadata1
    {
        public int? maxH { get; set; }
        public object maxW { get; set; }
        public int minH { get; set; }
        public int minW { get; set; }
        public Blankconfig1 blankConfig { get; set; }
        public bool requiresActivityDataSource { get; set; }
    }

    public class Blankconfig1
    {
        public string name { get; set; }
        public object end_time { get; set; }
        public bool read_only { get; set; }
        public bool show_jobs { get; set; }
        public string range_type { get; set; }
        public bool show_alias { get; set; }
        public bool show_shift { get; set; }
        public object start_time { get; set; }
        public bool show_operators { get; set; }
        public bool bluebar_enabled { get; set; }
        public object[] selected_shifts { get; set; }
        public bool show_status_codes { get; set; }
        public string selected_shift_mode { get; set; }
        public object refresh_rate_minutes { get; set; }
        public object[] selected_data_sources { get; set; }
        public bool show_connection_status { get; set; }
        public object selected_activity_data_source { get; set; }
        public object selected_connection_status_data_source { get; set; }
        public string bg_color { get; set; }
        public Threshold2 threshold { get; set; }
        public Threshold_22 threshold_2 { get; set; }
        public object display_type { get; set; }
        public Selected_Kpi2 selected_kpi { get; set; }
        public string decimal_places { get; set; }
        public bool hide_kpi_value { get; set; }
        public Display_Type_Opts1 display_type_opts { get; set; }
        public int refresh_rate_seconds { get; set; }
        public Jobs2 jobs { get; set; }
        public Notes2 notes { get; set; }
        public Scrap2 scrap { get; set; }
        public Operators2 operators { get; set; }
        public bool zoom_enabled { get; set; }
        public Operation_Codes2 operation_codes { get; set; }
        public int duration_seconds { get; set; }
        public bool show_attachment_type_labels { get; set; }
        public string chart_color { get; set; }
        public object target_value { get; set; }
        public object y_axis_title { get; set; }
        public bool show_bar_value { get; set; }
        public Selected_Report2 selected_report { get; set; }
        public bool show_average_line { get; set; }
    }

    public class Threshold2
    {
        public object ceds { get; set; }
        public object value { get; set; }
        public string bg_color { get; set; }
        public string test_type { get; set; }
        public string value_type { get; set; }
    }

    public class Threshold_22
    {
        public object ceds { get; set; }
        public object value { get; set; }
        public string bg_color { get; set; }
        public object test_type { get; set; }
        public string value_type { get; set; }
    }

    public class Selected_Kpi2
    {
        public object id { get; set; }
        public string name { get; set; }
        public object color { get; set; }
        public object[] shifts { get; set; }
        public string suffix { get; set; }
        public int type_id { get; set; }
        public bool all_shifts { get; set; }
        public bool shift_based { get; set; }
        public object sub_type_id { get; set; }
        public object[] data_sources { get; set; }
        public object static_result { get; set; }
        public object value_type_id { get; set; }
        public bool active_shift_based { get; set; }
        public object rolling_calculation_window { get; set; }
        public object semi_fixed_calculation_window { get; set; }
        public object[] narration_primitive_data_source_pairings { get; set; }
    }

    public class Display_Type_Opts1
    {
        public object max { get; set; }
        public object min { get; set; }
    }

    public class Jobs2
    {
        public bool entry_enabled { get; set; }
        public bool timeline_enabled { get; set; }
    }

    public class Notes2
    {
        public bool entry_enabled { get; set; }
        public bool timeline_enabled { get; set; }
    }

    public class Scrap2
    {
        public bool entry_enabled { get; set; }
        public bool timeline_enabled { get; set; }
        public bool force_job_selection { get; set; }
    }

    public class Operators2
    {
        public bool entry_enabled { get; set; }
        public bool timeline_enabled { get; set; }
    }

    public class Operation_Codes2
    {
        public bool entry_enabled { get; set; }
        public bool timeline_enabled { get; set; }
    }

    public class Selected_Report2
    {
        public object id { get; set; }
        public object[] jobs { get; set; }
        public string name { get; set; }
        public object color { get; set; }
        public object[] users { get; set; }
        public int offset { get; set; }
        public object[] shifts { get; set; }
        public string suffix { get; set; }
        public int divisor { get; set; }
        public object[] opcodes { get; set; }
        public int type_id { get; set; }
        public object end_time { get; set; }
        public object tick_rate { get; set; }
        public bool all_shifts { get; set; }
        public object start_time { get; set; }
        public object[] scrap_types { get; set; }
        public bool shift_based { get; set; }
        public object sub_type_id { get; set; }
        public object[] data_sources { get; set; }
        public object math_type_id { get; set; }
        public bool scrap_adjust { get; set; }
        public object chart_type_id { get; set; }
        public object value_type_id { get; set; }
        public object tick_rate_type_id { get; set; }
        public object time_step_seconds { get; set; }
        public int transition_type_id { get; set; }
        public object window_size_seconds { get; set; }
        public object report_range_type_id { get; set; }
        public object[] narration_primitive_data_source_pairings { get; set; }
    }

    public class Shift2
    {
        public int id { get; set; }
        public int company_id { get; set; }
        public string name { get; set; }
        public string start_date { get; set; }
        public int days_in_cycle { get; set; }
        public int created_at { get; set; }
        public int updated_at { get; set; }
        public object deleted_at { get; set; }
        public Shift_Days[] shift_days { get; set; }
    }

    public class Shift_Days
    {
        public int id { get; set; }
        public int shift_id { get; set; }
        public int created_at { get; set; }
        public int updated_at { get; set; }
        public object deleted_at { get; set; }
        public object[] breaks { get; set; }
        public Time_Ranges[] time_ranges { get; set; }
    }

    public class Time_Ranges
    {
        public int id { get; set; }
        public int shift_day_id { get; set; }
        public int day { get; set; }
        public string start { get; set; }
        public string end { get; set; }
        public int created_at { get; set; }
        public int updated_at { get; set; }
        public object deleted_at { get; set; }
    }

    public class Report_Range_Types
    {
        public int id { get; set; }
        public string key { get; set; }
        public string display_name { get; set; }
    }

    public class Data_Source_Types
    {
        public int id { get; set; }
        public string name { get; set; }
        public string desc { get; set; }
        public int created_at { get; set; }
        public int updated_at { get; set; }
        public object deleted_at { get; set; }
    }

    public class Panel_Tiers
    {
        public int id { get; set; }
        public string name { get; set; }
    }

    public class Panels_Preview_Info
    {
        public int id { get; set; }
        public string panel_type_key { get; set; }
        public int? tier_id { get; set; }
        public string preview_image { get; set; }
        public string preview_description { get; set; }
    }

    public class Timescale_Factors
    {
        public int id { get; set; }
        public float factor { get; set; }
        public string label { get; set; }
        public int created_at { get; set; }
        public int updated_at { get; set; }
        public object deleted_at { get; set; }
    }

    public class Value_Types
    {
        public int id { get; set; }
        public string key { get; set; }
        public string display_name { get; set; }
    }

    public class Report_Sub_Types
    {
        public int id { get; set; }
        public string key { get; set; }
        public string display_name { get; set; }
        public int display_order { get; set; }
    }

    public class Calculation_Window_Transition_Types
    {
        public int id { get; set; }
        public string key { get; set; }
        public string display_name { get; set; }
        public int sort { get; set; }
    }

    public class Chart_Types
    {
        public int id { get; set; }
        public string key { get; set; }
        public string display_name { get; set; }
    }

    public class Tick_Rate_Types
    {
        public int id { get; set; }
        public string key { get; set; }
        public string display_name { get; set; }
    }

    public class Math_Types
    {
        public int id { get; set; }
        public string key { get; set; }
        public string display_name { get; set; }
    }
}