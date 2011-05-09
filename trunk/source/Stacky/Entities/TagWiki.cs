using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Stacky
{
    public class TagWiki : Entity
    {
        private string tagName;
        private string wikiBody;
        private string wikiExcerpt;
        private DateTime bodyLastEditDate;
        private DateTime excerptLastEditDate;
        private UserInfo lastBodyEditor;
        private UserInfo lastExcerptEditor;

        [JsonProperty("tag_name")]
        public string TagName
        {
            get { return tagName; }
            set { tagName = value; NotifyOfPropertyChange(() => TagName); }
        }

        [JsonProperty("wiki_body")]
        public string WikiBody
        {
            get { return wikiBody; }
            set { wikiBody = value; NotifyOfPropertyChange(() => WikiBody); }
        }

        [JsonProperty("wiki_excerpt")]
        public string WikiExcerpt
        {
            get { return wikiExcerpt; }
            set { wikiExcerpt = value; NotifyOfPropertyChange(() => WikiExcerpt); }
        }

        [JsonProperty("body_last_edit_date"), JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime BodyLastEditDate
        {
            get { return bodyLastEditDate; }
            set { bodyLastEditDate = value; NotifyOfPropertyChange(() => BodyLastEditDate); }
        }

        [JsonProperty("excerpt_last_edit_date"), JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime ExcerptLastEditDate
        {
            get { return excerptLastEditDate; }
            set { excerptLastEditDate = value; NotifyOfPropertyChange(() => ExcerptLastEditDate); }
        }

        [JsonProperty("last_excerpt_editor")]
        public UserInfo LastExcerptEditor
        {
            get { return lastExcerptEditor; }
            set { lastExcerptEditor = value; NotifyOfPropertyChange(() => LastExcerptEditor); }
        }

        [JsonProperty("last_body_editor")]
        public UserInfo LastBodyEditor
        {
            get { return lastBodyEditor; }
            set { lastBodyEditor = value; NotifyOfPropertyChange(() => LastBodyEditor); }
        }
    }
}
