using System;

namespace IG.Csharp.Api.Client.Streaming.Model
{
    public class ClientListenerEventArgs : EventArgs
    {
        public DateTime UpdateTime { get; }
        public string Message { get; }

        public ClientListenerEventArgs(DateTime updateTime, string message)
        {
            UpdateTime = updateTime;
            Message = message;
        }
    }
}
