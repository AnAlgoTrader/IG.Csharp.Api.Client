using Newtonsoft.Json;

namespace IG.Csharp.Api.Client.Rest.Model
{
    public class LimitedRiskPremium
    {
        [JsonProperty("value")]
        public double Value { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }
    }
}
