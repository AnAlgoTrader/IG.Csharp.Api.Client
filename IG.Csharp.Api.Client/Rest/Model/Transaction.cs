using Newtonsoft.Json;
using System;

namespace IG.Csharp.Api.Client.Rest.Model
{
    public class Transaction
    {
        [JsonProperty("date")]
        public DateTime Date;

        [JsonProperty("dateUtc")]
        public DateTime DateUtc;

        [JsonProperty("openDateUtc")]
        public DateTime OpenDateUtc;

        [JsonProperty("instrumentName")]
        public string InstrumentName;

        [JsonProperty("period")]
        public string Period;

        [JsonProperty("profitAndLoss")]
        public string ProfitAndLoss;

        [JsonProperty("transactionType")]
        public string TransactionType;

        [JsonProperty("reference")]
        public string Reference;

        [JsonProperty("openLevel")]
        public string OpenLevel;

        [JsonProperty("closeLevel")]
        public string CloseLevel;

        [JsonProperty("size")]
        public string Size;

        [JsonProperty("currency")]
        public string Currency;

        [JsonProperty("cashTransaction")]
        public bool CashTransaction;
    }
}