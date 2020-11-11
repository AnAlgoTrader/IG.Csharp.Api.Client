using IG.Csharp.Api.Client.Rest.Response;
using Newtonsoft.Json;
using System;

namespace IG.Csharp.Api.Client.Rest.Model
{
    public class Price
    {
        [JsonProperty("snapshotTime")]
        public string SnapshotTime { get; set; }

        [JsonProperty("snapshotTimeUTC")]
        public DateTime SnapshotTimeUTC { get; set; }

        [JsonProperty("openPrice")]
        public PriceData OpenPrice { get; set; }

        [JsonProperty("closePrice")]
        public PriceData ClosePrice { get; set; }

        [JsonProperty("highPrice")]
        public PriceData HighPrice { get; set; }

        [JsonProperty("lowPrice")]
        public PriceData LowPrice { get; set; }

        [JsonProperty("lastTradedVolume")]
        public int LastTradedVolume { get; set; }
    }
}