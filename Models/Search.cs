using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace NicasourceAssessment.Models
{
    public class Search
    {
        public static readonly HttpClient client = new HttpClient();

        private JObject JsonSearchResult;
        
        [JsonInclude]
        public string response {get; set;}

        public  Search(string SearchURL)
        {
            var JsonSearchResult = GetSearchResponse(SearchURL);
        }

        public async Task<JObject> GetSearchResponse(string SearchURL)
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var streamTask = await client.GetStringAsync(SearchURL);
            var msg = streamTask.ToString();
            JsonSearchResult = JObject.Parse(msg);
            return JsonSearchResult;
        }
    }
}