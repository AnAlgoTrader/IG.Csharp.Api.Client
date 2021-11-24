using Newtonsoft.Json;

namespace IG.Csharp.Api.Client.Rest.Model
{
    public class Snapshot
    {
        [JsonProperty("marketStatus")]
        public string MarketStatus { get; set; }

        [JsonProperty("netChange")]
        public double NetChange { get; set; }

        [JsonProperty("percentageChange")]
        public double PercentageChange { get; set; }

        [JsonProperty("updateTime")]
        public string UpdateTime { get; set; }

        [JsonProperty("delayTime")]
        public int DelayTime { get; set; }

        [JsonProperty("bid")]
        public double Bid { get; set; }

        [JsonProperty("offer")]
        public double Offer { get; set; }

        [JsonProperty("high")]
        public double High { get; set; }

        [JsonProperty("low")]
        public double Low { get; set; }

        [JsonProperty("binaryOdds")]
        public object BinaryOdds { get; set; }

        [JsonProperty("decimalPlacesFactor")]
        public int DecimalPlacesFactor { get; set; }

        [JsonProperty("scalingFactor")]
        public int ScalingFactor { get; set; }

        [JsonProperty("controlledRiskExtraSpread")]
        public double ControlledRiskExtraSpread { get; set; }
    }
}