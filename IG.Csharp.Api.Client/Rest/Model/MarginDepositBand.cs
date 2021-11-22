using Newtonsoft.Json;

namespace IG.Csharp.Api.Client.Rest.Model
{
    public class MarginDepositBand
    {
        [JsonProperty("min")]
        public double Min { get; set; }

        [JsonProperty("max")]
        public double? Max { get; set; }

        [JsonProperty("margin")]
        public double Margin { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }
}