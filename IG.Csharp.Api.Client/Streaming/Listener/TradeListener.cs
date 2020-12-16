using System;
using com.lightstreamer.client;
using Newtonsoft.Json;
using IG.Csharp.Api.Client.Streaming.Model;

namespace IG.Csharp.Api.Client.Streaming.Listener
{
    public class TradeListener : SubscriptionListener
    {
        protected void OnItemUpdateHandler(TradeListenerEventArgs e)
        {
            OnTradeUpdate?.Invoke(this, e);
        }
        public event EventHandler<TradeListenerEventArgs> OnTradeUpdate;

        void SubscriptionListener.onClearSnapshot(string itemName, int itemPos)
        {
            throw new NotImplementedException();
        }

        void SubscriptionListener.onCommandSecondLevelItemLostUpdates(int lostUpdates, string key)
        {
            throw new NotImplementedException();
        }

        void SubscriptionListener.onCommandSecondLevelSubscriptionError(int code, string message, string key)
        {
            throw new NotImplementedException();
        }

        void SubscriptionListener.onEndOfSnapshot(string itemName, int itemPos)
        {

        }

        void SubscriptionListener.onItemLostUpdates(string itemName, int itemPos, int lostUpdates)
        {

        }

        void SubscriptionListener.onItemUpdate(ItemUpdate itemUpdate)
        {
            var json = JsonConvert.SerializeObject(itemUpdate.Fields, Formatting.Indented);
            OnItemUpdateHandler(new TradeListenerEventArgs(JsonConvert.DeserializeObject<TradeListenerData>(json)));
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
            throw new NotImplementedException();
        }

        void SubscriptionListener.onUnsubscription()
        {
            throw new NotImplementedException();
        }
    }
}
