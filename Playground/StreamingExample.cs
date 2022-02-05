using System;
using System.Collections.Generic;
using System.IO;
using IG.Csharp.Api.Client.Rest;
using IG.Csharp.Api.Client.Rest.Model;
using IG.Csharp.Api.Client.Streaming;
using IG.Csharp.Api.Client.Streaming.Listener;
using IG.Csharp.Api.Client.Streaming.Model;
using Newtonsoft.Json;

namespace Playground
{

    public class StreamingExample
    {
        private IgStreamingApiClient _streamingClient;

        public StreamingExample(){

            var personalSettings = JsonConvert.DeserializeObject<PersonalSettings>(File.ReadAllText("personalSettings.json"));

            //define rest client
            var igClient = new IgRestApiClient(
                personalSettings.AccountType, personalSettings.Username, personalSettings.Password, personalSettings.AppKey);
            var authenticationResponse = igClient.Authenticate();

            //define streaming client
            _streamingClient = new IgStreamingApiClient(authenticationResponse);           

        }
        public void Run(){
            //subscribe to connection updates
            var customClientListener = new CustomClientListener();
            customClientListener.OnClientUpdate += new EventHandler<ClientListenerEventArgs>(OnClientUpdate);
            _streamingClient.Connect(customClientListener);

            //subscribe to account updates
            var accountListener = new AccountListener();
            accountListener.OnAccountUpdate += new EventHandler<AccountDataEventArgs>(OnAccountUpdate);
            _streamingClient.SubcribeToAccountUpdates(accountListener);

            //subscribe to market updates
            var marketListener = new MarketListener();
            marketListener.OnMarketUpdate += new EventHandler<MarketDataEventArgs>(OnMarketUpdate);
            var epics = new List<string> (){ "CS.D.EURGBP.TODAY.IP" };
            _streamingClient.SubscribeToMarketUpdates(marketListener, epics);
        }

        private void OnMarketUpdate(object sender, MarketDataEventArgs marketDataArgs)
        {
            Console.WriteLine($"Market update received at:{DateTime.Now} Epic:{marketDataArgs.MarketData.Epic} Bid:{marketDataArgs.MarketData.Bid} Offer:{marketDataArgs.MarketData.Offer}");
        }

        private void OnAccountUpdate(object sender, AccountDataEventArgs accountDataArgs)
        {
            Console.WriteLine($"Account update received at:{DateTime.Now}");
            Console.WriteLine($"\tFunds:{accountDataArgs.AccountData.Funds}");
            Console.WriteLine($"\tAvailable:{accountDataArgs.AccountData.Available}");
            Console.WriteLine($"\tDeposit:{accountDataArgs.AccountData.Deposit}");
            Console.WriteLine($"\tPnl:{accountDataArgs.AccountData.Pnl}");
        }

        private void OnClientUpdate(object sender, ClientListenerEventArgs clientListenerArgs)
        {
            Console.WriteLine($"Connection update received at:{DateTime.Now} Message:{clientListenerArgs.Message}");
        }
    }
}
