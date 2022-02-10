using Newtonsoft.Json;

namespace IG.Csharp.Api.Client.Rest.Request
{
    public class OpenPositionRequest
    {
        [JsonProperty("currencyCode")]
        public string CurrencyCode { get; set; }

        [JsonProperty("dealReference")]
        public string DealReference { get; set; }

        [JsonProperty("direction")]
        public string Direction { get; set; }

        [JsonProperty("epic")]
        public string Epic { get; set; }

        [JsonProperty("expiry")]
        public string Expiry { get; set; }

        [JsonProperty("forceOpen")]
        public bool ForceOpen { get; set; }

        [JsonProperty("guaranteedStop")]
        public bool GuaranteedStop { get; set; }

        [JsonProperty("level")]
        public double? Level { get; set; }

        [JsonProperty("limitDistance")]
        public double? LimitDistance { get; set; }

        [JsonProperty("limitLevel")]
        public double? LimitLevel { get; set; }

        [JsonProperty("orderType")]
        public string OrderType { get; set; }

        [JsonProperty("quoteId")]
        public string QuoteId { get; set; }

        [JsonProperty("size")]
        public double? Size { get; set; }

        [JsonProperty("stopDistance")]
        public double? StopDistance { get; set; }

        [JsonProperty("stopLevel")]
        public double? StopLevel { get; set; }      

        [JsonProperty("trailingStop")]
        public bool TrailingStop { get; set; }

        [JsonProperty("trailingStopIncrement")]
        public double TrailingStopIncrement { get; set; }
    }
}
