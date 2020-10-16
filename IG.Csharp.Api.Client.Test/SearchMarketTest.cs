using IG.Csharp.Api.Client.Rest.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System.IO;

namespace IG.Csharp.Api.Client.Test
{
    [TestClass]
    public class SearchMarketTest
    {
        [TestMethod]
        public void SearchMarketTest0001()
        {
            var personalSettings = JsonConvert.DeserializeObject<PersonalSettings>(File.ReadAllText("personalSettings.json"));
            var restClient = IgClientHelper.GetIgRestApiClient(personalSettings);
            var response = restClient.Authenticate();
            Assert.IsNotNull(response.XSecurityToken);

            var markets = restClient.SearchMarkets("South Africa");
            Assert.IsNotNull(markets);
        }

        [TestMethod]
        public void GetMarketDetails0002()
        {
            var personalSettings = JsonConvert.DeserializeObject<PersonalSettings>(File.ReadAllText("personalSettings.json"));
            var restClient = IgClientHelper.GetIgRestApiClient(personalSettings);
            var response = restClient.Authenticate();
            Assert.IsNotNull(response.XSecurityToken);

            var details = restClient.GetMarketDetails("IX.D.SAF.DAILY.IP");
            Assert.IsNotNull(details);
        }
    }
}
