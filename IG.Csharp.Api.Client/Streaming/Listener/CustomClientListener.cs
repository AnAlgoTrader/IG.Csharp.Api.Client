using com.lightstreamer.client;
using IG.Csharp.Api.Client.Streaming.Model;
using System;

namespace IG.Csharp.Api.Client.Streaming.Listener
{
    public class CustomClientListener : ClientListener
    {
        protected void OnClientUpdateHandler(ClientListenerEventArgs e)
        {
            OnClientUpdate?.Invoke(this, e);
        }
        public event EventHandler<ClientListenerEventArgs> OnClientUpdate;

        void ClientListener.onListenEnd(LightstreamerClient client)
        {
            OnClientUpdateHandler(new ClientListenerEventArgs(DateTime.Now, $"Listen end"));
        }
        void ClientListener.onListenStart(LightstreamerClient client)
        {
            OnClientUpdateHandler(new ClientListenerEventArgs(DateTime.Now, $"Listen start"));
        }
        void ClientListener.onPropertyChange(string property)
        {            
        }
        void ClientListener.onServerError(int errorCode, string errorMessage)
        {
            var message = $"Error({errorCode}) | {errorMessage}";
            OnClientUpdateHandler(new ClientListenerEventArgs(DateTime.Now, message));
        }
        void ClientListener.onStatusChange(string status)
        {
            OnClientUpdateHandler(new ClientListenerEventArgs(DateTime.Now, $"Status: {status}"));
        }
    }
}