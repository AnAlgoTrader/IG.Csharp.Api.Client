using Newtonsoft.Json;

namespace IG.Csharp.Api.Client.Streaming.Model
{
    public class MarketData
    {
        [JsonProperty("MidOpen")]
        public double? MidOpen { get; set; }
        [JsonProperty("High")]
        public double? High { get; set; }
        [JsonProperty("Low")]
        public double? Low { get; set; }
        [JsonProperty("Change")]
        public double? Change { get; set; }
        [JsonProperty("ChangePct")]
        public double? ChangePct { get; set; }
        [JsonProperty("UpdateTime")]
        public string UpdateTime { get; set; }
        [JsonProperty("MarketDelay")]
        public int? MarketDelay { get; set; }
        [JsonProperty("MarketState")]
        public string MarketState { get; set; }
        [JsonProperty("Bid")]
        public double? Bid { get; set; }
        [JsonProperty("Offer")]
        public double? Offer { get; set; }

        public string Epic { get; set; }
    }
}