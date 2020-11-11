using Newtonsoft.Json;

namespace IG.Csharp.Api.Client.Rest.Model
{
    public class MetadataItem
    {
        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("pageData")]
        public PageData PageData { get; set; }

        [JsonProperty("allowance")]
        public Allowance Allowance { get; set; }
    }
}