using com.lightstreamer.client;
using IG.Csharp.Api.Client.Rest.Response;
using IG.Csharp.Api.Client.Streaming.Listener;
using System.Collections.ObjectModel;
using System.Diagnostics.Contracts;
using System.Linq;

namespace IG.Csharp.Api.Client.Streaming
{
    public class IgStreamingApiClient
    {
        private readonly LightstreamerClient _lsClient;
        private readonly string _accountId;
        public IgStreamingApiClient(AuthenticationResponse authenticationResponse)
        {
            Contract.Requires(authenticationResponse != null);

            _accountId = authenticationResponse.CurrentAccountId;
            _lsClient = new LightstreamerClient(authenticationResponse.LightstreamerEndpoint, "DEFAULT");
            _lsClient.connectionDetails.AdapterSet = "DEFAULT";
            _lsClient.connectionDetails.User = authenticationResponse.CurrentAccountId;
            _lsClient.connectionDetails.Password = $"CST-{authenticationResponse.Cst}|XST-{authenticationResponse.XSecurityToken}";
            _lsClient.connectionDetails.ServerAddress = authenticationResponse.LightstreamerEndpoint;
        }
        public void Connect(CustomClientListener customClientListener)
        {
            _lsClient.addListener(customClientListener);
            _lsClient.connect();
        }
        public void Disconnect()
        {
            _lsClient.disconnect();
        }
        public void SubcribeToAccountUpdates(AccountListener accountListener)
        {
            var accountSubscription = new Subscription("MERGE", new[] { "ACCOUNT:" + _accountId }, new[] { 
                "FUNDS", "PNL", "DEPOSIT", "USED_MARGIN", 
                "AMOUNT_DUE", "AVAILABLE_CASH" });
            accountSubscription.addListener(accountListener);
            _lsClient.subscribe(accountSubscription);
        }
        public void SubscribeToMarketUpdates(MarketListener marketListener, ReadOnlyCollection<string> epics)
        {
            var items = epics.Select(e => $"L1:{e}").ToArray();
            var marketSubscription = new Subscription("MERGE", items, new[] {
                    "MID_OPEN", "HIGH", "LOW", "CHANGE", "CHANGE_PCT", "UPDATE_TIME",
                    "MARKET_DELAY", "MARKET_STATE", "BID", "OFFER"
                });
            marketSubscription.addListener(marketListener);
            _lsClient.subscribe(marketSubscription);
        }
    }
}
