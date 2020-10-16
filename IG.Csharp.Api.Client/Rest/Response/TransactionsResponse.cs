using IG.Csharp.Api.Client.Rest.Model;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace IG.Csharp.Api.Client.Rest.Response
{
    public class TransactionsResponse
    {
        [JsonProperty("transactions")]
        public List<Transaction> Transactions;

        [JsonProperty("metadata")]
        public Metadata Metadata;
    }
}
