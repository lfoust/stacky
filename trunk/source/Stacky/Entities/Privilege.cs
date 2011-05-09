using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Stacky
{
    public class Privilege : Entity
    {
        private string shortDescription;
        private string description;
        private int reputation;
        
        /// <summary>
        /// The short description of the Privelege
        /// </summary>
        [JsonProperty("short_description")]
        public string ShortDescription
        {
            get { return shortDescription; }
            set { shortDescription = value; NotifyOfPropertyChange(() => ShortDescription); }
        }

        /// <summary>
        /// The description of the Privelege
        /// </summary>
        [JsonProperty("description")]
        public string Description
        {
            get { return description; }
            set { description = value; NotifyOfPropertyChange(() => Description); }
        }

        /// <summary>
        /// The amount of reputation that goes along with the <c ref="Reputation" />
        /// </summary>
        [JsonProperty("reputation")]
        public int Reputation
        {
            get { return reputation; }
            set { reputation = value; NotifyOfPropertyChange(() => Reputation); }
        }
    }
}