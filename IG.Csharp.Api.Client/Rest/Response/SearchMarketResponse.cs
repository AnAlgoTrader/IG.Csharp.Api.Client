using IG.Csharp.Api.Client.Rest.Model;
using Newtonsoft.Json;
using System.Collections.ObjectModel;

namespace IG.Csharp.Api.Client.Rest.Response
{
    public class SearchMarketResponse
    {
        [JsonProperty("markets")]
        public ReadOnlyCollection<MarketData> Markets { get; }
    }
}