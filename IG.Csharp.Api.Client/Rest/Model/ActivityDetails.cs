using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace IG.Csharp.Api.Client.Rest.Model
{
    public class ActivityDetails
    {
        [JsonProperty("dealReference")]
        public string DealReference { get; set; }

        [JsonProperty("actions")]
        public List<Model.Action> Actions { get; set; }

        [JsonProperty("marketName")]
        public string MarketName { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("size")]
        public double? Size { get; set; }

        [JsonProperty("direction")]
        public TradeSide Direction { get; set; }

        [JsonProperty("level")]
        public double? Level { get; set; }

        [JsonProperty("stopLevel")]
        public double? StopLevel { get; set; }

        [JsonProperty("stopDistance")]
        public double? StopDistance { get; set; }

        [JsonProperty("guaranteedStop")]
        public bool? GuaranteedStop { get; set; }

        [JsonProperty("trailingStopDistance")]
        public double? TrailingStopDistance { get; set; }

        [JsonProperty("trailingStep")]
        public double? TrailingStep { get; set; }

        [JsonProperty("limitLevel")]
        public double? LimitLevel { get; set; }

        [JsonProperty("limitDistance")]
        public double? LimitDistance { get; set; }
    }
}
