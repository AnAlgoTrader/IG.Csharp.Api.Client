using Newtonsoft.Json;

namespace IG.Csharp.Api.Client.Rest.Model
{
    public class LimitedRiskPremium
    {
        [JsonProperty("value")]
        public int Value;

        [JsonProperty("unit")]
        public string Unit;
    }
}
