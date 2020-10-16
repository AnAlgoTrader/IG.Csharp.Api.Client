using Newtonsoft.Json;

namespace IG.Csharp.Api.Client.Rest.Request
{
    public class OpenPositionRequest
    {        
        [JsonProperty("epic")]
        public string Epic { get; set; }
        [JsonProperty("expiry")]
        public string Expiry { get; set; }
        [JsonProperty("direction")]
        public string Direction { get; set; }
        [JsonProperty("size")]
        public double Size { get; set; }
        [JsonProperty("orderType")]
        public string OrderType { get; set; }
        [JsonProperty("guaranteedStop")]
        public bool GuaranteedStop { get; set; }
        [JsonProperty("trailingStop")]
        public bool TrailingStop { get; set; }
        [JsonProperty("forceOpen")]
        public bool ForceOpen { get; set; }
        [JsonProperty("currencyCode")]
        public string CurrencyCode { get; set; }
    }
}
