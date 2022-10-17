using Newtonsoft.Json;
using ShiftWorx.Components.Responses;
using System.Net;
using System.Net.Http.Headers;
using static System.Net.WebRequestMethods;

namespace ShiftWorx.Components.Methods
{
    public class FpData
    {
        static string Token { get; set; }
        static string UserId { get; set; }
        static HttpClient client = new HttpClient { BaseAddress = new("https://auth.getshiftworx.com/api/v1/") };
        public FpData()
        {
            LoginAsync("blunify_admin", "Blu@dmin0!", true);
        }
        public async Task LoginAsync(string username, string password, bool remember_me)
        {
            var data = new { username = username, password = password, remember_me = remember_me.ToString().ToLower() };

            var result = await client.PostAsJsonAsync("/api/v1/auth/login", data);
            var resultObj = await result.Content.ReadAsStringAsync();
            var obj = JsonConvert.DeserializeObject<LoginResponse>(resultObj);
            Token = obj.data.token;
            UserId = obj.data.userid;
            client.DefaultRequestHeaders.Add("sid", UserId);
            client.DefaultRequestHeaders.Add("stv", Token);
            client.DefaultRequestHeaders.Add("pid", "19");
            client.DefaultRequestHeaders.Add("dscid", "1");
        }
        public async Task<GetBlueBarResponse> GetBlueBar(string data_source_id, string StartDate, string EndDate)
        {
            var url = "datasources/input/state/changes?data_source_id=" + data_source_id + "&range_start=" + StartDate + "&range_end=" + EndDate + "&for_graphing=true&min_on_time=60&max_on_time=0&min_off_time=60&max_off_time=0&min_on_time_modifier=0&max_on_time_modifier=0";
            var result = await client.GetAsync(url);
            var resultObj = await result.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<GetBlueBarResponse>(resultObj);
        } 
        public async Task<KpiReportResponse> GetKpiReport(string data_source_id)
        {
            var url = "report-definition/run?id=" + data_source_id;
            var result = await client.GetAsync(url);
            var resultObj = await result.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<KpiReportResponse>(resultObj);
        }
        public async Task<UserSimplifiedResponse> GetSimplifiedUser(string data_source_id)
        {
            var url = "user/simplified-list?mode=obfuscate&with_current_attachments=true&active=true&data_source_id=" + data_source_id;
            var result = await client.GetAsync(url);
            var resultObj = await result.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<UserSimplifiedResponse>(resultObj);
        }
    }
}
