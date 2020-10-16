using IG.Csharp.Api.Client.Rest.Model;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace IG.Csharp.Api.Client.Rest.Response
{
    public class SearchMarketResponse
    {
        [JsonProperty("markets")]
        public List<MarketData> Markets { get; set; }
    }
}
