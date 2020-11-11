using IG.Csharp.Api.Client.Rest.Model;
using Newtonsoft.Json;
using System.Collections.ObjectModel;

namespace IG.Csharp.Api.Client.Rest.Response
{
    public class TransactionsResponse
    {
        [JsonProperty("transactions")]
        public ReadOnlyCollection<Transaction> Transactions { get; set; }

        [JsonProperty("metadata")]
        public MetadataItem MetaData { get; set; }
    }
}
