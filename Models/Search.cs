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
        private static readonly HttpClient client = new HttpClient();
        [JsonInclude]
        public JObject FormattedResponse {get; set;}
        public string SearchURL {get; set;}
        public Task<JObject> JsonSearchResultFormatted;

        public Search(string SearchURL)
        {
            this.SearchURL = SearchURL;
            FormattedResponse = GetFormattedResponse();
        }

        public JObject GetFormattedResponse()
        {
            JsonSearchResultFormatted = Task.Run( () => GetSearchResponse(this.SearchURL));
            JsonSearchResultFormatted.Wait();
            return JsonSearchResultFormatted.Result;
        }

        public async Task<JObject> GetSearchResponse(string SearchURL)
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var streamTask = await client.GetStringAsync(SearchURL);
            var msg = streamTask.ToString();
            return JObject.Parse(msg);
        }
    }
}