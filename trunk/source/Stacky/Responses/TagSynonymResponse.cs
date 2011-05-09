using System.Collections.Generic;
using Newtonsoft.Json;

namespace Stacky
{
    public class TagSynonymResponse : Response
    {
        [JsonProperty("tag_synonyms")]
        public List<TagSynonym> TagSynonyms { get; set; }
    }
}