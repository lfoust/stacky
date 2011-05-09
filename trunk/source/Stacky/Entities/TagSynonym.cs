using System;
using Newtonsoft.Json;

namespace Stacky
{
    public class TagSynonym : Entity
    {
        private string fromTag;
        private string toTag;
        private int appliedCount;
        private DateTime creationDate;
        private DateTime lastAppliedDate;

        /// <summary>
        /// Gets or sets the from tag.
        /// </summary>
        [JsonProperty("from_tag")]
        public string FromTag
        {
            get { return fromTag; }
            set { fromTag = value; NotifyOfPropertyChange(() => FromTag); }
        }

        /// <summary>
        /// Gets or sets the to tag.
        /// </summary>
        [JsonProperty("to_tag")]
        public string ToTag
        {
            get { return toTag; }
            set { toTag = value; NotifyOfPropertyChange(() => ToTag); }
        }

        /// <summary>
        /// Gets or sets the applied count
        /// </summary>
        [JsonProperty("applied_count")]
        public int AppliedCount
        {
            get { return appliedCount; }
            set { appliedCount = value; NotifyOfPropertyChange(() => AppliedCount); }
        }

        /// <summary>
        /// Gets or sets the last applied date
        /// </summary>
        [JsonProperty("last_applied_date"), JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime LastAppliedDate
        {
            get { return lastAppliedDate; }
            set { lastAppliedDate = value; NotifyOfPropertyChange(() => LastAppliedDate); }
        }

        /// <summary>
        /// Gets or sets the creation date
        /// </summary>
        [JsonProperty("creation_date"), JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime CreationDate
        {
            get { return creationDate; }
            set { creationDate = value; NotifyOfPropertyChange(() => CreationDate); }
        }
    }
}
