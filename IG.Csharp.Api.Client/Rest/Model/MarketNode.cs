using Newtonsoft.Json;

namespace IG.Csharp.Api.Client.Rest.Model
{
    public class MarketNode
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
