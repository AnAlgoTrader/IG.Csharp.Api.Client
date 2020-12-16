using System;
using Newtonsoft.Json;

namespace IG.Csharp.Api.Client.Streaming.Model
{
    public class AffectedDeal
    {
        [JsonProperty("dealId")]
        public string DealId { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
