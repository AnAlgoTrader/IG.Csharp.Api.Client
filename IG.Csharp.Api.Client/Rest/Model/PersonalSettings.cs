using Newtonsoft.Json;

namespace IG.Csharp.Api.Client.Rest.Model
{
    public class PersonalSettings
    {
        [JsonProperty("AccountType")]
        public string AccountType { get; set; }

        [JsonProperty("Username")]
        public string Username { get; set; }

        [JsonProperty("Password")]
        public string Password { get; set; }

        [JsonProperty("AppKey")]
        public string AppKey { get; set; }

        [JsonProperty("DbServer")]
        public string DbServer { get; set; }

        [JsonProperty("DbUser")]
        public string DbUser { get; set; }

        [JsonProperty("DbPassword")]
        public string DbPassword { get; set; }

        [JsonProperty("DbName")]
        public string DbName { get; set; }
    }
}