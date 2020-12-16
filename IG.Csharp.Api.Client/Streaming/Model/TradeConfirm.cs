using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace IG.Csharp.Api.Client.Streaming.Model
{
    public class TradeConfirm
    {
        [JsonProperty("direction")]
        public string Direction { get; set; }

        [JsonProperty("epic")]
        public string Epic { get; set; }

        [JsonProperty("stopLevel")]
        public double StopLevel { get; set; }

        [JsonProperty("limitLevel")]
        public double LimitLevel { get; set; }

        [JsonProperty("dealReference")]
        public string DealReference { get; set; }

        [JsonProperty("dealId")]
        public string DealId { get; set; }

        [JsonProperty("limitDistance")]
        public double LimitDistance { get; set; }

        [JsonProperty("stopDistance")]
        public double StopDistance { get; set; }

        [JsonProperty("expiry")]
        public string Expiry { get; set; }

        [JsonProperty("affectedDeals")]
        public List<AffectedDeal> AffectedDeals { get; set; }

        [JsonProperty("dealStatus")]
        public string DealStatus { get; set; }

        [JsonProperty("guaranteedStop")]
        public bool GuaranteedStop { get; set; }

        [JsonProperty("trailingStop")]
        public bool TrailingStop { get; set; }

        [JsonProperty("level")]
        public double Level { get; set; }

        [JsonProperty("reason")]
        public string Reason { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("size")]
        public long Size { get; set; }

        [JsonProperty("profit")]
        public double Profit { get; set; }

        [JsonProperty("profitCurrency")]
        public string ProfitCurrency { get; set; }

        [JsonProperty("date")]
        public DateTime Date { get; set; }

        [JsonProperty("channel")]
        public string Channel { get; set; }
    }
}
