using System.Collections.Generic;
using Newtonsoft.Json;

namespace Stacky
{
    public class SitesResponse
    {
        [JsonProperty("items")]
        public List<SiteInfo> Sites { get; set; }
    }
}