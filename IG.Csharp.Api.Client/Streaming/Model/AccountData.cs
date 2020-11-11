using Newtonsoft.Json;

namespace IG.Csharp.Api.Client.Streaming.Model
{
    public class AccountData
    {
        public double Funds { get; set; }
        public double Pnl { get; set; }
        public double Deposit { get; set; }
        public double UsedMargin { get; set; }
        public double AmountDue { get; set; }
        [JsonProperty("AVAILABLE_CASH")]
        public double Available { get; set; }
    }
}