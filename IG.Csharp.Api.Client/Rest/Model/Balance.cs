using Newtonsoft.Json;

namespace IG.Csharp.Api.Client.Rest.Model
{
    public class Balance
    {
        [JsonProperty("balance")]
        public double Amount { get; set; }

        [JsonProperty("deposit")]
        public double Deposit { get; set; }

        [JsonProperty("profitLoss")]
        public double ProfitLoss { get; set; }

        [JsonProperty("available")]
        public double Available { get; set; }
    }
}