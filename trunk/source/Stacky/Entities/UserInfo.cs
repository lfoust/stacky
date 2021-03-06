﻿using System;
using Newtonsoft.Json;

namespace Stacky
{
    /// <summary>
    /// Represents user information.
    /// </summary>
    public class UserInfo : Entity
    {
        private int? userId;
        private UserType type;
        private string displayName;
        private int? reputation;
        private string emailHash;

        /// <summary>
        /// Gets or sets the user id.
        /// </summary>
        /// <value>The user id.</value>
        [JsonProperty("user_id")]
        public int? UserId
        {
            get { return userId; }
            set { userId = value; NotifyOfPropertyChange(() => UserId); }
        }

        /// <summary>
        /// Gets or sets the <see cref="UserType"/>.
        /// </summary>
        /// <value>The <see cref="UserType"/>.</value>
        [JsonProperty("user_type"), JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public UserType Type
        {
            get { return type; }
            set { type = value; NotifyOfPropertyChange(() => Type); }
        }

        /// <summary>
        /// Gets or sets the display name.
        /// </summary>
        /// <value>The display name.</value>
        [JsonProperty("display_name")]
        public string DisplayName
        {
            get { return displayName; }
            set { displayName = value; NotifyOfPropertyChange(() => DisplayName); }
        }

        /// <summary>
        /// Gets or sets the reputation.
        /// </summary>
        /// <value>The reputation.</value>
        [JsonProperty("reputation")]
        public int? Reputation
        {
            get { return reputation; }
            set { reputation = value; NotifyOfPropertyChange(() => Reputation); }
        }

        /// <summary>
        /// Gets or sets the email hash.
        /// </summary>
        /// <value>The email hash.</value>
        [JsonProperty("email_hash")]
        public string EmailHash
        {
            get { return emailHash; }
            set { emailHash = value; NotifyOfPropertyChange(() => EmailHash); NotifyOfPropertyChange(() => GravatarUrl); }
        }

        /// <summary>
        /// Gets the gravatar URL.
        /// </summary>
        /// <value>The gravatar URL.</value>
        public string GravatarUrl { get { return String.Format("http://www.gravatar.com/avatar/{0}?d=identicon&r=PG", EmailHash); } }
    }
}