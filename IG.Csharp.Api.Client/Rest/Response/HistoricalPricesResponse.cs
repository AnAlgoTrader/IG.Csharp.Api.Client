using IG.Csharp.Api.Client.Rest.Model;
using Newtonsoft.Json;
using System.Collections.ObjectModel;

namespace IG.Csharp.Api.Client.Rest.Response
{
    public class HistoricalPricesResponse
    {
        [JsonProperty("prices")]
        public ReadOnlyCollection<Price> Prices { get; }

        [JsonProperty("instrumentType")]
        public string InstrumentType { get; set; }

        [JsonProperty("metadata")]
        public MetadataItem Metadata { get; set; }
    }
}