using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Stacky
{
    public class TopUserResponse : Response
    {
        [JsonProperty("top_users")]
        public List<TopUser> TopUsers { get; set; }
    }
}
