using System.Collections.Generic;
using Newtonsoft.Json;

namespace Stacky
{
    public class TopTagResponse : Response
    {
        [JsonProperty("top_tags")]
        public List<TopTag> TopTags { get; set; }
    }
}