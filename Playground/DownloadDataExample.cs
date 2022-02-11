using System;
using System.IO;
using IG.Csharp.Api.Client;
using IG.Csharp.Api.Client.Rest;
using IG.Csharp.Api.Client.Rest.Model;
using Newtonsoft.Json;

namespace Playground
{

    public class DownloadDataExample
    {
        private IgRestApiClient _igClient;

        public DownloadDataExample()
        {
            var personalSettings = JsonConvert.DeserializeObject<PersonalSettings>(File.ReadAllText("personalSettings.json"));
            _igClient = new IgRestApiClient(
                personalSettings.AccountType, personalSettings.Username, personalSettings.Password, personalSettings.AppKey);
            _igClient.Authenticate();
        }
        public void Run()
        {
            var resolution = (Resolution)Enum.Parse(typeof(Resolution), "HOUR");
            var prices = _igClient.GetHistoricalPrices("CS.D.EURGBP.TODAY.IP", resolution,
                new System.DateTime(2022, 02, 05), new System.DateTime(2022, 02, 10));
        }
    }
}
