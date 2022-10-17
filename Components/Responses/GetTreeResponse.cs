﻿namespace ShiftWorx.Components.Responses
{
    public class GetTreeResponse
    {
        public class Data_Tree
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
            public bool isVisible { get; set; }
        }

        public string message { get; set; }
        public List<Data_Tree> data { get; set; }


    }
}
