using System.Collections.Generic;
using Newtonsoft.Json;

namespace Stacky
{
    public class TagWikiResponse : Response
    {
        [JsonProperty("tag_wikis")]
        public List<TagWiki> TagWikis { get; set; }
    }
}