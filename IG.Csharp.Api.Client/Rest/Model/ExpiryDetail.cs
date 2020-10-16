using Newtonsoft.Json;

namespace IG.Csharp.Api.Client.Rest.Model
{
    public class ExpiryDetail
    {
        [JsonProperty("lastDealingDate")]
        public string LastDealingDate;

        [JsonProperty("settlementInfo")]
        public string SettlementInfo;
    }
}
