using Newtonsoft.Json;

namespace IG.Csharp.Api.Client.Rest.Model
{
    public class DealingRule
    {
        [JsonProperty("minStepDistance")]
        public Distance MinStepDistance { get; set; }

        [JsonProperty("minDealSize")]
        public MinDealSize MinDealSize { get; set; }

        [JsonProperty("minControlledRiskStopDistance")]
        public Distance MinControlledRiskStopDistance { get; set; }

        [JsonProperty("minNormalStopOrLimitDistance")]
        public Distance MinNormalStopOrLimitDistance { get; set; }

        [JsonProperty("maxStopOrLimitDistance")]
        public Distance MaxStopOrLimitDistance { get; set; }

        [JsonProperty("marketOrderPreference")]
        public string MarketOrderPreference { get; set; }

        [JsonProperty("trailingStopsPreference")]
        public string TrailingStopsPreference { get; set; }
    }
}