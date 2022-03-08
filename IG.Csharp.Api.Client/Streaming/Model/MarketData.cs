using Newtonsoft.Json;

namespace IG.Csharp.Api.Client.Streaming.Model
{
    public class MarketData
    {
        [JsonProperty("Mid_Open")]
        public double? MidOpen { get; set; }

        [JsonProperty("High")]
        public double? High { get; set; }

        [JsonProperty("Low")]
        public double? Low { get; set; }

        [JsonProperty("Change")]
        public double? Change { get; set; }

        [JsonProperty("Change_Pct")]
        public double? ChangePct { get; set; }

        [JsonProperty("Update_Time")]
        public string UpdateTime { get; set; }

        [JsonProperty("Market_Delay")]
        public int? MarketDelay { get; set; }

        [JsonProperty("Market_State")]
        public string MarketState { get; set; }

        [JsonProperty("Bid")]
        public double Bid { get; set; }

        [JsonProperty("Offer")]
        public double Offer { get; set; }

        [JsonProperty("Epic")]
        public string Epic { get; set; }
    }
}