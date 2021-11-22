using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace IG.Csharp.Api.Client.Rest.Model
{
    public partial class Instrument
    {
        [JsonProperty("epic")]
        public string Epic { get; set; }

        [JsonProperty("expiry")]
        public string Expiry { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("forceOpenAllowed")]
        public bool ForceOpenAllowed { get; set; }

        [JsonProperty("stopsLimitsAllowed")]
        public bool StopsLimitsAllowed { get; set; }

        [JsonProperty("lotSize")]
        public long LotSize { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("controlledRiskAllowed")]
        public bool ControlledRiskAllowed { get; set; }

        [JsonProperty("streamingPricesAvailable")]
        public bool StreamingPricesAvailable { get; set; }

        [JsonProperty("marketId")]
        public string MarketId { get; set; }

        [JsonProperty("currencies")]
        public List<Currency> Currencies { get; set; }

        [JsonProperty("sprintMarketsMinimumExpiryTime")]
        public object SprintMarketsMinimumExpiryTime { get; set; }

        [JsonProperty("sprintMarketsMaximumExpiryTime")]
        public object SprintMarketsMaximumExpiryTime { get; set; }

        [JsonProperty("marginDepositBands")]
        public List<MarginDepositBand> MarginDepositBands { get; set; }

        [JsonProperty("marginFactor")]
        public double MarginFactor { get; set; }

        [JsonProperty("marginFactorUnit")]
        public string MarginFactorUnit { get; set; }

        [JsonProperty("openingHours")]
        public object OpeningHours { get; set; }

        [JsonProperty("rolloverDetails")]
        public object RolloverDetails { get; set; }

        [JsonProperty("newsCode")]
        public string NewsCode { get; set; }

        [JsonProperty("chartCode")]
        public string ChartCode { get; set; }

        [JsonProperty("country")]
        public object Country { get; set; }

        [JsonProperty("valueOfOnePip")]
        public object ValueOfOnePip { get; set; }

        [JsonProperty("onePipMeans")]
        public object OnePipMeans { get; set; }

        [JsonProperty("contractSize")]
        public object ContractSize { get; set; }

        [JsonProperty("specialInfo")]
        public List<string> SpecialInfo { get; set; }
    }
}
