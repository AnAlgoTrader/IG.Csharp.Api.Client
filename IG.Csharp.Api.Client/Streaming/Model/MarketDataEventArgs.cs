using System;

namespace IG.Csharp.Api.Client.Streaming.Model
{
    public class MarketDataEventArgs : EventArgs
    {
        public MarketData MarketData { get; }

        public MarketDataEventArgs(MarketData marketData)
        {
            MarketData = marketData;
        }
    }
}
