using Newtonsoft.Json;

namespace IG.Csharp.Api.Client.Rest.Model
{
    public class OpenPosition
    {
        [JsonProperty("position")]
        public OpenPositionData Position { get; set; }
        [JsonProperty("market")]
        public MarketData Market { get; set; }
    }
}