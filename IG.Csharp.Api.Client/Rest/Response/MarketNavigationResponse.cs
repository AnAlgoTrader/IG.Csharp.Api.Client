using IG.Csharp.Api.Client.Rest.Model;
using System.Collections.Generic;

namespace IG.Csharp.Api.Client.Rest.Response
{
    public class MarketNavigationResponse
    {
        public List<MarketNode> nodes { get; set; }
        public List<MarketData> markets { get; set; }
    }
}
