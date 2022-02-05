using System;
using System.IO;
using IG.Csharp.Api.Client.Rest;
using IG.Csharp.Api.Client.Rest.Model;
using Newtonsoft.Json;

namespace Playground
{

    public class AuthenticationExample
    {
        private IgRestApiClient _igRestApiClient;

        internal void Run()
        {
            var response = _igRestApiClient.Authenticate();
            if (!string.IsNullOrEmpty(response.XSecurityToken))
            {
                Console.WriteLine($"Lightstreamer endpoint: {response.LightstreamerEndpoint}");
            }
            else Console.WriteLine("Not Authenticated");
        }

        public AuthenticationExample()
        {
            var personalSettings = JsonConvert.DeserializeObject<PersonalSettings>(File.ReadAllText("personalSettings.json"));
            _igRestApiClient = new IgRestApiClient(personalSettings.AccountType, personalSettings.Username, personalSettings.Password, personalSettings.AppKey);
        }
    }
}
