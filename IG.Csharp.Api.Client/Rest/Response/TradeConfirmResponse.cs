using Newtonsoft.Json;
using System;
using System.Collections.ObjectModel;

namespace IG.Csharp.Api.Client.Rest.Response
{
    public class TradeConfirmResponse
    {
        [JsonProperty("date")]
        public DateTime Date { get; set; }

        [JsonProperty("status")]
        public object Status { get; set; }

        [JsonProperty("reason")]
        public string Reason { get; set; }

        [JsonProperty("dealStatus")]
        public string DealStatus { get; set; }

        [JsonProperty("epic")]
        public string Epic { get; set; }

        [JsonProperty("expiry")]
        public object Expiry { get; set; }

        [JsonProperty("dealReference")]
        public string DealReference { get; set; }

        [JsonProperty("dealId")]
        public string DealId { get; set; }

        [JsonProperty("affectedDeals")]
        public ReadOnlyCollection<string> AffectedDeals { get; }

        [JsonProperty("level")]
        public object Level { get; set; }

        [JsonProperty("size")]
        public object Size { get; set; }

        [JsonProperty("direction")]
        public string Direction { get; set; }

        [JsonProperty("stopLevel")]
        public object StopLevel { get; set; }

        [JsonProperty("limitLevel")]
        public object LimitLevel { get; set; }

        [JsonProperty("stopDistance")]
        public object StopDistance { get; set; }

        [JsonProperty("limitDistance")]
        public object LimitDistance { get; set; }

        [JsonProperty("guaranteedStop")]
        public bool GuaranteedStop { get; set; }

        [JsonProperty("trailingStop")]
        public bool TrailingStop { get; set; }

        [JsonProperty("profit")]
        public object Profit { get; set; }

        [JsonProperty("profitCurrency")]
        public object ProfitCurrency { get; set; }
    }
}
