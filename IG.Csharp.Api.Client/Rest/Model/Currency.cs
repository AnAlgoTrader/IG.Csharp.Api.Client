using Newtonsoft.Json;

namespace IG.Csharp.Api.Client.Rest.Model
{
    public class Currency
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("symbol")]
        public string Symbol { get; set; }

        [JsonProperty("baseExchangeRate")]
        public double BaseExchangeRate { get; set; }

        [JsonProperty("exchangeRate")]
        public double ExchangeRate { get; set; }

        [JsonProperty("isDefault")]
        public bool IsDefault { get; set; }
    }
}
