using Newtonsoft.Json;

namespace IG.Csharp.Api.Client.Rest.Model
{
    public class MinStepDistance
    {
        [JsonProperty("unit")]
        public string Unit;

        [JsonProperty("value")]
        public double Value;
    }
}
