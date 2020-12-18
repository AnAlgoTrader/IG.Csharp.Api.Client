using System;
using Newtonsoft.Json;

namespace IG.Csharp.Api.Client.Rest.Model
{
    public class Action
    {
        [JsonProperty("actionType")]
        public string ActionType { get; set; }

        [JsonProperty("affectedDealId")]
        public string AffectedDealId { get; set; }
    }
}
