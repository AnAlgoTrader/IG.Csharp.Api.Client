using IG.Csharp.Api.Client.Rest.Model;
using Newtonsoft.Json;

namespace IG.Csharp.Api.Client.Rest.Response
{
    public class MarketDetailsResponse
    {
        [JsonProperty("instrument")]
        public Instrument Instrument { get; set; }

        [JsonProperty("dealingRules")]
        public DealingRule DealingRules { get; set; }
    }
}