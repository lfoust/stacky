using System.Collections.Generic;
using Newtonsoft.Json;

namespace Stacky
{
    public class PrivilegeResponse
    {
        [JsonProperty("privileges")]
        public List<Privilege> Privileges { get; set; }
    }
}
