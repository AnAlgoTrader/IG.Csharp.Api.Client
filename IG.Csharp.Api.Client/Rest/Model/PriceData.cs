using Newtonsoft.Json;

namespace IG.Csharp.Api.Client.Rest.Model
{
    public class PriceData
    {
        [JsonProperty("bid")]
        public float Bid { get; set; }

        [JsonProperty("ask")]
        public float Ask { get; set; }

        [JsonProperty("lastTraded")]
        public object LastTraded { get; set; }
    }
}