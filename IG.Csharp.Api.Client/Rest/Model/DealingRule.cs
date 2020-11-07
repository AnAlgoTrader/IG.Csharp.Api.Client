using Newtonsoft.Json;

namespace IG.Csharp.Api.Client.Rest.Model
{
    public class DealingRule
    {
        [JsonProperty("minStepDistance")]
        public Distance MinStepDistance;

        [JsonProperty("minDealSize")]
        public MinDealSize MinDealSize;

        [JsonProperty("minControlledRiskStopDistance")]
        public Distance MinControlledRiskStopDistance;

        [JsonProperty("minNormalStopOrLimitDistance")]
        public Distance MinNormalStopOrLimitDistance;

        [JsonProperty("maxStopOrLimitDistance")]
        public Distance MaxStopOrLimitDistance;

        [JsonProperty("marketOrderPreference")]
        public string MarketOrderPreference;

        [JsonProperty("trailingStopsPreference")]
        public string TrailingStopsPreference;
    }
}
