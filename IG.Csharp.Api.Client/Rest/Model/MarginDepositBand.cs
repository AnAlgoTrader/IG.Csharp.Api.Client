using Newtonsoft.Json;

namespace IG.Csharp.Api.Client.Rest.Model
{
    public class MarginDepositBand
    {
        [JsonProperty("min")]
        public int Min { get; set; }

        [JsonProperty("max")]
        public int? Max { get; set; }

        [JsonProperty("margin")]
        public int Margin { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }
}