using Newtonsoft.Json;

namespace IG.Csharp.Api.Client.Rest.Model
{
    public class DealingRule
    {
        [JsonProperty("minStepDistance")]
        public MinStepDistance MinStepDistance;

        [JsonProperty("minDealSize")]
        public MinDealSize MinDealSize;

        [JsonProperty("minControlledRiskStopDistance")]
        public MinControlledRiskStopDistance MinControlledRiskStopDistance;

        [JsonProperty("minNormalStopOrLimitDistance")]
        public MinNormalStopOrLimitDistance MinNormalStopOrLimitDistance;

        [JsonProperty("maxStopOrLimitDistance")]
        public MaxStopOrLimitDistance MaxStopOrLimitDistance;

        [JsonProperty("marketOrderPreference")]
        public string MarketOrderPreference;

        [JsonProperty("trailingStopsPreference")]
        public string TrailingStopsPreference;
    }
}
