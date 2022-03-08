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
    }
}