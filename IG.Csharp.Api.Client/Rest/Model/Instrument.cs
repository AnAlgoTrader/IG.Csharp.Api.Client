using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace IG.Csharp.Api.Client.Rest.Model
{
    public class Instrument
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
        public double LotSize { get; set; }

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
        public ReadOnlyCollection<Currency> Currencies { get; set; }

        [JsonProperty("sprintMarketsMinimumExpiryTime")]
        public object SprintMarketsMinimumExpiryTime { get; set; }

        [JsonProperty("sprintMarketsMaximumExpiryTime")]
        public object SprintMarketsMaximumExpiryTime { get; set; }

        [JsonProperty("marginDepositBands")]
        public ReadOnlyCollection<MarginDepositBand> MarginDepositBands { get; }

        [JsonProperty("marginFactor")]
        public double MarginFactor { get; set; }

        [JsonProperty("marginFactorUnit")]
        public string MarginFactorUnit { get; set; }

        [JsonProperty("slippageFactor")]
        public SlippageFactor SlippageFactor { get; set; }

        [JsonProperty("limitedRiskPremium")]
        public LimitedRiskPremium LimitedRiskPremium { get; set; }

        [JsonProperty("openingHours")]
        public object OpeningHours { get; set; }

        [JsonProperty("expiryDetails")]
        public ExpiryDetail ExpiryDetails { get; set; }

        [JsonProperty("rolloverDetails")]
        public object RolloverDetails { get; set; }

        [JsonProperty("newsCode")]
        public string NewsCode { get; set; }

        [JsonProperty("chartCode")]
        public object ChartCode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("valueOfOnePip")]
        public object ValueOfOnePip { get; set; }

        [JsonProperty("onePipMeans")]
        public object OnePipMeans { get; set; }

        [JsonProperty("contractSize")]
        public object ContractSize { get; set; }

        [JsonProperty("specialInfo")]
        public ReadOnlyCollection<string> SpecialInfo { get; set; }
    }
}
