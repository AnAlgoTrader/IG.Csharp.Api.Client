using IG.Csharp.Api.Client.Rest.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace IG.Csharp.Api.Client.Rest.Response
{
    public class AuthenticationResponse
    {
        [JsonProperty("accountType")]
        public string AccountType { get; set; }

        [JsonProperty("igCompany")]
        public string IgCompany { get; set; }

        [JsonProperty("kycFormUrl")]
        public Uri KycFormUrl { get; set; }

        [JsonProperty("encrypted")]
        public bool Encrypted { get; set; }

        [JsonProperty("accountInfo")]
        public AccountInfo AccountInfo { get; set; }

        [JsonProperty("currencyIsoCode")]
        public string CurrencyIsoCode { get; set; }

        [JsonProperty("currencySymbol")]
        public string CurrencySymbol { get; set; }

        [JsonProperty("currentAccountId")]
        public string CurrentAccountId { get; set; }

        [JsonProperty("lightstreamerEndpoint")]
        public string LightstreamerEndpoint { get; set; }

        [JsonProperty("accounts")]
        public ReadOnlyCollection<AccountDetails> Accounts { get; set; }

        [JsonProperty("clientId")]
        public string ClientId { get; set; }

        [JsonProperty("timezoneOffset")]
        public int TimezoneOffset { get; set; }

        [JsonProperty("hasActiveDemoAccounts")]
        public bool HasActiveDemoAccounts { get; set; }

        [JsonProperty("hasActiveLiveAccounts")]
        public bool HasActiveLiveAccounts { get; set; }

        [JsonProperty("trailingStopsEnabled")]
        public bool TrailingStopsEnabled { get; set; }

        [JsonProperty("reroutingEnvironment")]
        public string ReroutingEnvironment { get; set; }

        [JsonProperty("cst")]
        public string Cst { get; set; }

        [JsonProperty("xSecurityToken")]
        public string XSecurityToken { get; set; }

        [JsonProperty("apiKey")]
        public string ApiKey { get; set; }

        [JsonProperty("date")]
        public DateTime Date { get; internal set; }
    }
}
