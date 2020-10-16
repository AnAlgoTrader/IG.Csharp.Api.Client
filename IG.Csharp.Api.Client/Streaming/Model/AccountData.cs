using Newtonsoft.Json;

namespace IG.Csharp.Api.Client.Streaming.Model
{
    public class AccountData
    {
        public double Funds;
        public double Pnl;
        public double Deposit;
        public double UsedMargin;
        public double AmountDue;
        [JsonProperty("AVAILABLE_CASH")]
        public double Available;
    }
}

