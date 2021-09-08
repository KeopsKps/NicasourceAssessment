

using Newtonsoft.Json.Linq;

namespace NicasourceAssessment.Models
{
    public class Character : CharacterSearch
    {
        public string FullName {get; set;}
        public string FirstAppearance {get; set;}
        public JObject PowerStats {get; set;}
        public JObject Appeareance {get; set;}
        public JObject Biography {get; set;}

    }
}