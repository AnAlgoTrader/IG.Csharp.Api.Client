using Newtonsoft.Json;

namespace IG.Csharp.Api.Client.Rest.Model
{
    public class Watchlist
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("editable")]
        public bool Editable { get; set; }

        [JsonProperty("deleteable")]
        public bool Deleteable { get; set; }

        [JsonProperty("defaultSystemWatchlist")]
        public bool DefaultSystemWatchlist { get; set; }
    }
}