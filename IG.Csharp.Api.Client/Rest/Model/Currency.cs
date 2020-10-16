using Newtonsoft.Json;

namespace IG.Csharp.Api.Client.Rest.Model
{
    public class Currency
    {
        [JsonProperty("code")]
        public string Code;

        [JsonProperty("symbol")]
        public string Symbol;

        [JsonProperty("baseExchangeRate")]
        public double BaseExchangeRate;

        [JsonProperty("exchangeRate")]
        public double ExchangeRate;

        [JsonProperty("isDefault")]
        public bool IsDefault;
    }
}
