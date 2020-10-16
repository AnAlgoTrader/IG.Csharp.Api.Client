using IG.Csharp.Api.Client.Rest.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System.IO;

namespace IG.Csharp.Api.Client.Test
{
    [TestClass]
    public class WatchListTest
    {
        [TestMethod]
        public void WatchListTest0001()
        {
            var personalSettings = JsonConvert.DeserializeObject<PersonalSettings>(File.ReadAllText("personalSettings.json"));
            var restClient = IgClientHelper.GetIgRestApiClient(personalSettings);
            var response = restClient.Authenticate();

            var watchLists = restClient.GetWatchLists();
            var watchList = restClient.GetInstrumentsByWatchlistId(watchLists.watchlists[0].id);
        }
    }
}
