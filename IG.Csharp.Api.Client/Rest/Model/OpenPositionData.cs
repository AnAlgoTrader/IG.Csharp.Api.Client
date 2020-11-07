using Newtonsoft.Json;

namespace IG.Csharp.Api.Client.Rest.Model
{
    public class OpenPositionData
    {
        [JsonProperty("contractSize")]
        public double ContractSize { get; set; }

        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("dealId")]
        public string DealId { get; set; }

        [JsonProperty("dealReference")]
        public string DealReference { get; set; }

        [JsonProperty("size")]
        public double Size { get; set; }

        [JsonProperty("direction")]
        public string Direction { get; set; }

        [JsonProperty("limitLevel")]
        public decimal? LimitLevel { get; set; }

        [JsonProperty("level")]
        public double Level { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("controlledRisk")]
        public bool ControlledRisk { get; set; }

        [JsonProperty("stopLevel")]
        public decimal? StopLevel { get; set; }

        [JsonProperty("trailingStop")]
        public decimal? TrailingStop { get; set; }

        [JsonProperty("trailingStopDistance")]
        public decimal? TrailingStopDistance { get; set; }

        [JsonProperty("profitAndLoss")]
        public double ProfitAndLoss { get; set; }
    }
}