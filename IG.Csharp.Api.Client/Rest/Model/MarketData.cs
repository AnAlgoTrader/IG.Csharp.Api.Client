using Newtonsoft.Json;

namespace IG.Csharp.Api.Client.Rest.Model
{
    public class MarketData
    {
        [JsonProperty("instrumentName")]
        public string InstrumentName { get; set; }

        [JsonProperty("expiry")]
        public string Expiry { get; set; }

        [JsonProperty("epic")]
        public string Epic { get; set; }

        [JsonProperty("instrumentType")]
        public string InstrumentType { get; set; }

        [JsonProperty("lotSize")]
        public decimal? LotSize { get; set; }

        [JsonProperty("high")]
        public decimal? High { get; set; }

        [JsonProperty("low")]
        public decimal? Low { get; set; }

        [JsonProperty("percentageChange")]
        public decimal? PercentageChange { get; set; }

        [JsonProperty("netChange")]
        public decimal? NetChange { get; set; }

        [JsonProperty("bid")]
        public double? Bid { get; set; }

        [JsonProperty("offer")]
        public double? Offer { get; set; }

        [JsonProperty("updateTime")]
        public string UpdateTime { get; set; }

        [JsonProperty("delayTime")]
        public int DelayTime { get; set; }

        [JsonProperty("streamingPricesAvailable")]
        public bool StreamingPricesAvailable { get; set; }

        [JsonProperty("otcTradeable")]
        public bool OtcTradeable { get; set; }

        [JsonProperty("marketStatus")]
        public string MarketStatus { get; set; }

        [JsonProperty("scalingFactor")]
        public int ScalingFactor { get; set; }
    }
}