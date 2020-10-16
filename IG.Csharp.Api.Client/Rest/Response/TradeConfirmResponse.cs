using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace IG.Csharp.Api.Client.Rest.Response
{
    public class TradeConfirmResponse
    {
        [JsonProperty("date")]
        public DateTime Date;

        [JsonProperty("status")]
        public object Status;

        [JsonProperty("reason")]
        public string Reason;

        [JsonProperty("dealStatus")]
        public string DealStatus;

        [JsonProperty("epic")]
        public string Epic;

        [JsonProperty("expiry")]
        public object Expiry;

        [JsonProperty("dealReference")]
        public string DealReference;

        [JsonProperty("dealId")]
        public string DealId;

        [JsonProperty("affectedDeals")]
        public List<object> AffectedDeals;

        [JsonProperty("level")]
        public object Level;

        [JsonProperty("size")]
        public object Size;

        [JsonProperty("direction")]
        public string Direction;

        [JsonProperty("stopLevel")]
        public object StopLevel;

        [JsonProperty("limitLevel")]
        public object LimitLevel;

        [JsonProperty("stopDistance")]
        public object StopDistance;

        [JsonProperty("limitDistance")]
        public object LimitDistance;

        [JsonProperty("guaranteedStop")]
        public bool GuaranteedStop;

        [JsonProperty("trailingStop")]
        public bool TrailingStop;

        [JsonProperty("profit")]
        public object Profit;

        [JsonProperty("profitCurrency")]
        public object ProfitCurrency;
    }
}
