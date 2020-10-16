using Newtonsoft.Json;

namespace IG.Csharp.Api.Client.Rest.Model
{
    public class Metadata
    {
        [JsonProperty("size")]
        public int Size;

        [JsonProperty("pageData")]
        public PageData PageData;
    }
}