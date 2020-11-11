using IG.Csharp.Api.Client.Rest.Model;
using Newtonsoft.Json;
using System.Collections.ObjectModel;

namespace IG.Csharp.Api.Client.Rest.Response
{
    public class AccountDetailsResponse
    {
        [JsonProperty("accounts")]
        public ReadOnlyCollection<AccountDetails> Accounts { get; set; }
    }
}