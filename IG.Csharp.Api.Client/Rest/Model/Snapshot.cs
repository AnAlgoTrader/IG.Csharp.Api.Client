using Newtonsoft.Json;

namespace IG.Csharp.Api.Client.Rest.Model
{
    public class Snapshot
    {
        [JsonProperty("marketStatus")]
        public string MarketStatus;

        [JsonProperty("netChange")]
        public int NetChange;

        [JsonProperty("percentageChange")]
        public double PercentageChange;

        [JsonProperty("updateTime")]
        public string UpdateTime;

        [JsonProperty("delayTime")]
        public int DelayTime;

        [JsonProperty("bid")]
        public double Bid;

        [JsonProperty("offer")]
        public double Offer;

        [JsonProperty("high")]
        public double High;

        [JsonProperty("low")]
        public double Low;

        [JsonProperty("binaryOdds")]
        public object BinaryOdds;

        [JsonProperty("decimalPlacesFactor")]
        public int DecimalPlacesFactor;

        [JsonProperty("scalingFactor")]
        public int ScalingFactor;

        [JsonProperty("controlledRiskExtraSpread")]
        public int ControlledRiskExtraSpread;
    }
}