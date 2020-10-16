using Newtonsoft.Json;

namespace IG.Csharp.Api.Client.Rest.Model
{
    public class MarginDepositBand
    {
        [JsonProperty("min")]
        public int Min;

        [JsonProperty("max")]
        public int? Max;

        [JsonProperty("margin")]
        public int Margin;

        [JsonProperty("currency")]
        public string Currency;
    }
}
