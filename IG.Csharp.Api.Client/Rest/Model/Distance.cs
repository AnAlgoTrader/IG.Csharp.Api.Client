using Newtonsoft.Json;

namespace IG.Csharp.Api.Client.Rest.Model
{
    public class Distance
    {
        [JsonProperty("unit")]
        public string Unit;

        [JsonProperty("value")]
        public double Value;
    }
}