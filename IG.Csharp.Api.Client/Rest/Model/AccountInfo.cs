using Newtonsoft.Json;

namespace IG.Csharp.Api.Client.Rest.Model
{
    public class AccountInfo
    {
        [JsonProperty("balance")]
        public double Balance { get; set; }

        [JsonProperty("deposit")]
        public double Deposit { get; set; }

        [JsonProperty("profitLoss")]
        public double ProfitLoss { get; set; }

        [JsonProperty("available")]
        public double Available { get; set; }
    }
}