using Newtonsoft.Json;

namespace Stacky
{
    public class SiteInfo : Entity
    {
        [JsonProperty("main_site")]
        public Site MainSite { get; set; }

        [JsonProperty("related_sites")]
        public System.Collections.Generic.IEnumerable<RelatedSite> RelatedSites { get; set; }
    }
}