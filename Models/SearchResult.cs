namespace NicasourceAssessment.Models
{
    public class SearchResult
    {
        public bool IsSearchResult {get; set;}
        public string response {get; set;}

        public SearchResult(bool IsSearchResult)
        {
            this.IsSearchResult = IsSearchResult;
        }
    }
}