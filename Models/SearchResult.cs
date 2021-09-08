using Newtonsoft.Json.Linq;
using NicasourceAssessment.Models;

namespace NicasourceAssessment.Models
{
    public class SearchResult
    {
        public bool IsSearchResult {get; set;}
        public SearchResult(bool IsSearchResult)
        {
            this.IsSearchResult = IsSearchResult;
        }

    }
}