using Newtonsoft.Json;

namespace IG.Csharp.Api.Client.Rest.Request
{
    public class ClosePositionLimitRequest
    {
        [JsonProperty("dealId")]
        public string DealId { get; set; }
        [JsonProperty("orderType")]
        public string OrderType { get; set; }
        [JsonProperty("direction")]
        public string Direction { get; set; }
        [JsonProperty("size")]
        public double Size { get; set; }
        [JsonProperty("level")]
        public double Level { get; set; }
        [JsonProperty("timeInForce")]
        public string TimeInForce { get; set; }
    }
}
