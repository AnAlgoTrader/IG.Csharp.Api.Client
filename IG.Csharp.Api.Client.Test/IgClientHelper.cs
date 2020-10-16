using IG.Csharp.Api.Client.Rest;
using IG.Csharp.Api.Client.Rest.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IG.Csharp.Api.Client.Test
{
    public class IgClientHelper
    {
        public static IgRestApiClient GetIgRestApiClient(PersonalSettings personalSettings)
        {
            Assert.IsNotNull(personalSettings);
            Assert.IsNotNull(personalSettings.AccountType);
            Assert.IsNotNull(personalSettings.Username);
            Assert.IsNotNull(personalSettings.Password);
            Assert.IsNotNull(personalSettings.AppKey);
            Assert.AreEqual(personalSettings.AccountType, "demo"); //Force to run tests on the demo platform

            return new IgRestApiClient(personalSettings.AccountType, personalSettings.Username, personalSettings.Password, personalSettings.AppKey);
        }
    }
}
