using System;
using System.IO;
using IG.Csharp.Api.Client;
using IG.Csharp.Api.Client.Rest;
using IG.Csharp.Api.Client.Rest.Model;
using Newtonsoft.Json;

namespace Playground
{
    class Program
    {
        static void Main(string[] args)
        {
            var personalSettings = JsonConvert.DeserializeObject<PersonalSettings>(File.ReadAllText("personalSettings.json"));
            var igClient = new IgRestApiClient(
                personalSettings.AccountType, personalSettings.Username, personalSettings.Password, personalSettings.AppKey);
            var authenticationResponse = igClient.Authenticate();

            var response = igClient.OpenMarketTrailingPosition("CS.D.EURGBP.TODAY.IP", TradeSide.BUY, 1, 10, 50);
            if (string.IsNullOrEmpty(response.ErrorCode))
                Console.WriteLine($"Position opened with deal reference:{response.DealReference}");
            else
                Console.WriteLine($"Error opening the position:{response.ErrorCode}");
        }
    }
}
