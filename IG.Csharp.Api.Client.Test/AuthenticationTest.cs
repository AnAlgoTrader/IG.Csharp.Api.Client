using IG.Csharp.Api.Client.Rest.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System.IO;

namespace IG.Csharp.Api.Client.Test
{
    [TestClass]
    public class AuthenticationTest
    {
        [TestMethod]
        public void AuthenticationTest0001()
        {
            var personalSettings = JsonConvert.DeserializeObject<PersonalSettings>(File.ReadAllText("personalSettings.json"));
            var client = IgClientHelper.GetIgRestApiClient(personalSettings);
            var response = client.Authenticate();
            Assert.IsNotNull(response.XSecurityToken);
        }
    }
}
