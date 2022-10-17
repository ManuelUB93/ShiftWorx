using static ShiftWorx.Components.Responses.StatusResponse;

namespace ShiftWorx.Components.Responses
{
    public class PassthroughResponse
    {
        public class AdministrationSetting_Pass
        {
            public int id { get; set; }
            public int enabled { get; set; }
            public string feature_permission { get; set; }
            public int product_id { get; set; }
            public int access_level { get; set; }
            public string access_level_name { get; set; }
        }

        public class Core_Pass
        {
            public int product_id { get; set; }
            public int access_level { get; set; }
            public string access_level_name { get; set; }
        }

        public class Dashboard_Pass
        {
            public int product_id { get; set; }
            public int access_level { get; set; }
            public string access_level_name { get; set; }
        }

        public class Data_Pass
        {
            public User_Pass user { get; set; }
            public List<Factory_Pass> factories { get; set; }
            public ProductAccess_Pass product_access { get; set; }
            public FeaturePermissions_Pass feature_permissions { get; set; }
            public string user_timezone { get; set; }
            public string user_language { get; set; }
            public bool use_meridiem { get; set; }
        }

        public class DataSource_Pass
        {
            public int id { get; set; }
            public int parent_id { get; set; }
            public int type_id { get; set; }
            public object primitive_type_id { get; set; }
            public object activity_definition_id { get; set; }
            public object filters_and_modifiers_id { get; set; }
            public string name { get; set; }
            public string desc { get; set; }
            public int is_active { get; set; }
            public int hidden { get; set; }
            public object num_val { get; set; }
            public string str_val { get; set; }
            public object json_val { get; set; }
            public object blob_val { get; set; }
            public int created_at { get; set; }
            public int updated_at { get; set; }
            public object deleted_at { get; set; }
            public object lineage_within_company_name { get; set; }
            public Pivot_Pass pivot { get; set; }
        }

        public class Factory_Pass
        {
            public int id { get; set; }
            public string name { get; set; }
            public string str_val { get; set; }
            public object blob_val { get; set; }
            public string lineage_within_company_name { get; set; }
        }

        public class FeaturePermissions_Pass
        {
            public List<LegacyWatchLive_Pass> legacy_watch_live { get; set; }
            public List<Narrative_Pass> narrative { get; set; }
            public List<Scheduler_Pass> scheduler { get; set; }
            public List<AdministrationSetting_Pass> administration_settings { get; set; }
            public List<ModularNarrative_Pass> modular_narrative { get; set; }
            public List<Shiftworx_Pass> shiftworx { get; set; }
        }

        public class FreepointConnectServer_Pass
        {
            public int product_id { get; set; }
            public int access_level { get; set; }
            public string access_level_name { get; set; }
        }

        public class FreepointPublications_Pass
        {
            public int product_id { get; set; }
            public int access_level { get; set; }
            public string access_level_name { get; set; }
        }

        public class LegacyWatchLive_Pass
        {
            public int product_id { get; set; }
            public int access_level { get; set; }
            public string access_level_name { get; set; }
            public int id { get; set; }
            public int enabled { get; set; }
            public string feature_permission { get; set; }
        }

        public class ModularNarrative_Pass
        {
            public int id { get; set; }
            public int enabled { get; set; }
            public string feature_permission { get; set; }
            public int product_id { get; set; }
        }

        public class Narrative_Pass
        {
            public int product_id { get; set; }
            public int access_level { get; set; }
            public string access_level_name { get; set; }
            public int id { get; set; }
            public int enabled { get; set; }
            public string feature_permission { get; set; }
        }

        public class Pivot_Pass
        {
            public int user_id { get; set; }
            public int data_source_id { get; set; }
            public int created_at { get; set; }
            public int updated_at { get; set; }
        }

        public class ProductAccess_Pass
        {
            public LegacyWatchLive_Pass legacy_watch_live { get; set; }
            public Narrative_Pass narrative { get; set; }
            public Scheduler_Pass scheduler { get; set; }
            public AdministrationSetting_Pass administration_settings { get; set; }
            public ProductDocumentation_Pass product_documentation { get; set; }
            public FreepointPublications_Pass freepoint_publications { get; set; }
            public UserProfile_Pass user_profile { get; set; }
            public Dashboard_Pass dashboard { get; set; }
            public Core_Pass core { get; set; }
            public RemoteFirmware_Pass remote_firmware { get; set; }
            public FreepointConnectServer_Pass freepoint_connect_server { get; set; }
            public Shiftworx_Pass shiftworx { get; set; }
            public PublicApi_Pass public_api { get; set; }
        }

        public class ProductDocumentation_Pass
        {
            public int product_id { get; set; }
            public int access_level { get; set; }
            public string access_level_name { get; set; }
        }

        public class PublicApi_Pass
        {
            public int product_id { get; set; }
            public int access_level { get; set; }
            public string access_level_name { get; set; }
        }

        public class RemoteFirmware_Pass
        {
            public int product_id { get; set; }
            public int access_level { get; set; }
            public string access_level_name { get; set; }
        }
        public string message { get; set; }
        public Data_Pass data { get; set; }

        public class Scheduler_Pass
        {
            public int product_id { get; set; }
            public int access_level { get; set; }
            public string access_level_name { get; set; }
            public int id { get; set; }
            public int enabled { get; set; }
            public string feature_permission { get; set; }
        }

        public class Shiftworx_Pass
        {
            public int product_id { get; set; }
            public int access_level { get; set; }
            public string access_level_name { get; set; }
            public int id { get; set; }
            public int enabled { get; set; }
            public string feature_permission { get; set; }
        }

        public class User_Pass
        {
            public string id { get; set; }
            public string username { get; set; }
            public string display_name { get; set; }
            public string email { get; set; }
            public string first_name { get; set; }
            public string last_name { get; set; }
            public string cellphone { get; set; }
            public int new_password { get; set; }
            public int is_active { get; set; }
            public int is_pseudo_user { get; set; }
            public int role_id { get; set; }
            public int account_type_id { get; set; }
            public object image { get; set; }
            public string badge_number { get; set; }
            public string job_title { get; set; }
            public string reference_number { get; set; }
            public int has_set_up_account { get; set; }
            public object color { get; set; }
            public int created_at { get; set; }
            public int updated_at { get; set; }
            public object deleted_at { get; set; }
            public List<DataSource_Pass> data_sources { get; set; }
            public int dscid { get; set; }
        }

        public class UserProfile_Pass
        {
            public int product_id { get; set; }
            public int access_level { get; set; }
            public string access_level_name { get; set; }
        }

    }
}
