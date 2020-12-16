using com.lightstreamer.client;
using IG.Csharp.Api.Client.Streaming.Model;
using Newtonsoft.Json;
using System;
using System.Diagnostics.Contracts;

namespace IG.Csharp.Api.Client.Streaming.Listener
{
    public class MarketListener : SubscriptionListener
    {
        protected void OnMarketUpdateHandler(MarketDataEventArgs e)
        {
            OnMarketUpdate?.Invoke(this, e);
        }

        public event EventHandler<MarketDataEventArgs> OnMarketUpdate;

        void SubscriptionListener.onClearSnapshot(string itemName, int itemPos)
        {
            throw new System.NotImplementedException();
        }

        void SubscriptionListener.onCommandSecondLevelItemLostUpdates(int lostUpdates, string key)
        {
            throw new System.NotImplementedException();
        }

        void SubscriptionListener.onCommandSecondLevelSubscriptionError(int code, string message, string key)
        {
            throw new System.NotImplementedException();
        }

        void SubscriptionListener.onEndOfSnapshot(string itemName, int itemPos)
        {
            throw new System.NotImplementedException();
        }

        void SubscriptionListener.onItemLostUpdates(string itemName, int itemPos, int lostUpdates)
        {
            throw new System.NotImplementedException();
        }

        void SubscriptionListener.onItemUpdate(ItemUpdate itemUpdate)
        {
            Contract.Requires(itemUpdate != null);

            var json = JsonConvert.SerializeObject(itemUpdate.Fields, Formatting.Indented);
            var marketData = JsonConvert.DeserializeObject<MarketData>(json);
            marketData.Epic = itemUpdate.ItemName.Replace("MARKET:", string.Empty, StringComparison.InvariantCulture);
            OnMarketUpdateHandler(new MarketDataEventArgs(marketData));
        }

        void SubscriptionListener.onListenEnd(Subscription subscription)
        {
        }

        void SubscriptionListener.onListenStart(Subscription subscription)
        {
        }

        void SubscriptionListener.onRealMaxFrequency(string frequency)
        {
        }

        void SubscriptionListener.onSubscription()
        {
        }

        void SubscriptionListener.onSubscriptionError(int code, string message)
        {
            throw new System.NotImplementedException();
        }

        void SubscriptionListener.onUnsubscription()
        {
            throw new System.NotImplementedException();
        }
    }
}
