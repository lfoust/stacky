using Newtonsoft.Json;

namespace Stacky
{
    public class RelatedSite : Entity
    {
        private string name;
        private string siteUrl;
        private string relation;

        [JsonProperty("name")]
        public string Name
        {
            get { return name; }
            set { name = value; NotifyOfPropertyChange(() => Name); }
        }

        [JsonProperty("site_url")]
        public string SiteUrl
        {
            get { return siteUrl; }
            set { siteUrl = value; NotifyOfPropertyChange(() => SiteUrl); }
        }

        [JsonProperty("relation")]
        public string Relation
        {
            get { return relation; }
            set { relation = value; NotifyOfPropertyChange(() => Relation); }
        }
    }
}