using IG.Csharp.Api.Client.Rest.Model;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace IG.Csharp.Api.Client.Rest.Response
{
    public class PositionsResponse
    {
        [JsonProperty("positions")]
        public List<OpenPosition> Positions { get; set; }
    }
}