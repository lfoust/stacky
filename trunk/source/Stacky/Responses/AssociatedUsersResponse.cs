using System.Collections.Generic;
using Newtonsoft.Json;

namespace Stacky
{
    public class AssociatedUsersResponse
    {
        [JsonProperty("items")]
        public List<AssociatedUser> Users { get; set; }
    }
}