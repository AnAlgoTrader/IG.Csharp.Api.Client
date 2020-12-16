using System;
using Newtonsoft.Json;

namespace IG.Csharp.Api.Client.Streaming.Model
{
    public class TradeListenerEventArgs : EventArgs
    {
        public TradeConfirm TradeConfirm { get; }

        public TradeListenerEventArgs(TradeListenerData message)
        {
            if (message != null)
            {
                TradeConfirm = JsonConvert.DeserializeObject<TradeConfirm>(message.Confirms);
            }
        }
    }
}
