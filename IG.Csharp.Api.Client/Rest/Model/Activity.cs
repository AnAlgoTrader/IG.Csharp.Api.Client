using Newtonsoft.Json;
using System;

namespace IG.Csharp.Api.Client.Rest.Model
{
    public class Activity
    {
        [JsonProperty("date")]
        public DateTime Date { get; set; }

        [JsonProperty("epic")]
        public string Epic { get; set; }

        [JsonProperty("period")]
        public string Period { get; set; }

        [JsonProperty("dealId")]
        public string DealId { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }
}