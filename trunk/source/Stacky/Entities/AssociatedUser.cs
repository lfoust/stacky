using System;
using Newtonsoft.Json;

namespace Stacky
{
    public class AssociatedUser : Entity
    {
        private int id;
        private string siteName;
        private DateTime userCreationDate;
        private string associationId;

        /// <summary>
        /// Gets or sets the user id.
        /// </summary>
        /// <value>The user id.</value>
        [JsonProperty("user_id")]
        public int Id
        {
            get { return id; }
            set { id = value; NotifyOfPropertyChange(() => Id); }
        }

        [JsonProperty("site_name")]
        public string SiteName
        {
            get { return siteName; }
            set { siteName = value; NotifyOfPropertyChange(() => SiteName); }
        }

        [JsonProperty("user_creation_date"), JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime UserCreationDate
        {
            get { return userCreationDate; }
            set { userCreationDate = value; NotifyOfPropertyChange(() => UserCreationDate); }
        }

        [JsonProperty("association_id")]
        public string AssociationId
        {
            get { return associationId; }
            set { associationId = value; NotifyOfPropertyChange(() => AssociationId); }
        }
    }
}
