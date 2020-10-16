using Newtonsoft.Json;

namespace IG.Csharp.Api.Client.Rest.Request
{
    public class CreateWorkingOrderRequest
    {
        [JsonProperty("epic")]
        public string Epic { get; set; }
        [JsonProperty("expiry")]
        public string Expiry { get; set; }
        [JsonProperty("direction")]
        public string Direction { get; set; }
        [JsonProperty("size")]
        public double Size { get; set; }
        [JsonProperty("timeInForce")]
        public string TimeInForce { get; set; }
        [JsonProperty("currencyCode")]
        public string CurrencyCode { get; set; }
        [JsonProperty("guaranteedStop")]
        public bool GuaranteedStop { get; set; }
        [JsonProperty("stopDistance")]
        public double? StopDistance { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("level")]
        public double Level { get; set; }
        [JsonProperty("forceOpen")]
        public bool ForceOpen { get; set; }
    }
}
