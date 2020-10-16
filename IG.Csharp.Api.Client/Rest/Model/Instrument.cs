using IG.Csharp.Api.Client.Rest.Model;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace IG.Csharp.Api.Client.Rest.Model
{
    public class Instrument
    {
        [JsonProperty("epic")]
        public string Epic;

        [JsonProperty("expiry")]
        public string Expiry;

        [JsonProperty("name")]
        public string Name;

        [JsonProperty("forceOpenAllowed")]
        public bool ForceOpenAllowed;

        [JsonProperty("stopsLimitsAllowed")]
        public bool StopsLimitsAllowed;

        [JsonProperty("lotSize")]
        public double LotSize;

        [JsonProperty("unit")]
        public string Unit;

        [JsonProperty("type")]
        public string Type;

        [JsonProperty("controlledRiskAllowed")]
        public bool ControlledRiskAllowed;

        [JsonProperty("streamingPricesAvailable")]
        public bool StreamingPricesAvailable;

        [JsonProperty("marketId")]
        public string MarketId;

        [JsonProperty("currencies")]
        public List<Currency> Currencies;

        [JsonProperty("sprintMarketsMinimumExpiryTime")]
        public object SprintMarketsMinimumExpiryTime;

        [JsonProperty("sprintMarketsMaximumExpiryTime")]
        public object SprintMarketsMaximumExpiryTime;

        [JsonProperty("marginDepositBands")]
        public List<MarginDepositBand> MarginDepositBands;

        [JsonProperty("marginFactor")]
        public int MarginFactor;

        [JsonProperty("marginFactorUnit")]
        public string MarginFactorUnit;

        [JsonProperty("slippageFactor")]
        public SlippageFactor SlippageFactor;

        [JsonProperty("limitedRiskPremium")]
        public LimitedRiskPremium LimitedRiskPremium;

        [JsonProperty("openingHours")]
        public object OpeningHours;

        [JsonProperty("expiryDetails")]
        public ExpiryDetail ExpiryDetails;

        [JsonProperty("rolloverDetails")]
        public object RolloverDetails;

        [JsonProperty("newsCode")]
        public string NewsCode;

        [JsonProperty("chartCode")]
        public object ChartCode;

        [JsonProperty("country")]
        public string Country;

        [JsonProperty("valueOfOnePip")]
        public object ValueOfOnePip;

        [JsonProperty("onePipMeans")]
        public object OnePipMeans;

        [JsonProperty("contractSize")]
        public object ContractSize;

        [JsonProperty("specialInfo")]
        public List<string> SpecialInfo;
    }
}
