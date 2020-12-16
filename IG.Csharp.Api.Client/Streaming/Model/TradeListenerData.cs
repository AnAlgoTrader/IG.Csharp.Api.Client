using System;
using Newtonsoft.Json;

namespace IG.Csharp.Api.Client.Streaming.Model
{
    public class TradeListenerData
    {
        [JsonProperty("CONFIRMS")]
        public String Confirms { get; set; }

        [JsonProperty("OPU")]
        public String Opu { get; set; }

        [JsonProperty("WOU")]
        public String Wou { get; set; }
    }
}
