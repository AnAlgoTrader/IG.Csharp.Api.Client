using Newtonsoft.Json;
using System;

namespace IG.Csharp.Api.Client.Rest.Model
{
    public class Transaction
    {
        [JsonProperty("date")]
        public DateTime Date { get; set; }

        [JsonProperty("dateUtc")]
        public DateTime DateUtc { get; set; }

        [JsonProperty("openDateUtc")]
        public DateTime OpenDateUtc { get; set; }

        [JsonProperty("instrumentName")]
        public string InstrumentName { get; set; }

        [JsonProperty("period")]
        public string Period { get; set; }

        [JsonProperty("profitAndLoss")]
        public string ProfitAndLoss { get; set; }

        [JsonProperty("transactionType")]
        public string TransactionType { get; set; }

        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("openLevel")]
        public string OpenLevel { get; set; }

        [JsonProperty("closeLevel")]
        public string CloseLevel { get; set; }

        [JsonProperty("size")]
        public string Size { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("cashTransaction")]
        public bool CashTransaction { get; set; }
    }
}