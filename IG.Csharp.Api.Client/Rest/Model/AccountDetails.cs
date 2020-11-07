using Newtonsoft.Json;

namespace IG.Csharp.Api.Client.Rest.Model
{
    public class AccountDetails
    {
        [JsonProperty("accountId")]
        public string AccountId { get; set; }
        [JsonProperty("accountName")]
        public string AccountName { get; set; }
        [JsonProperty("preferred")]
        public bool Preferred { get; set; }
        [JsonProperty("accountType")]
        public string AccountType { get; set; }
        [JsonProperty("balance")]
        public Balance Balance { get; set; }
    }
}