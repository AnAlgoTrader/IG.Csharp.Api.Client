using System;
using com.lightstreamer.client;
using Newtonsoft.Json;

namespace IG.Csharp.Api.Client.Streaming.Listener
{
    public class TradeListener : SubscriptionListener
    {
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
            throw new NotImplementedException();
        }

        void SubscriptionListener.onItemLostUpdates(string itemName, int itemPos, int lostUpdates)
        {

        }

        void SubscriptionListener.onItemUpdate(ItemUpdate itemUpdate)
        {
            var json = JsonConvert.SerializeObject(itemUpdate.Fields, Formatting.Indented);
            Console.WriteLine(json);
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
