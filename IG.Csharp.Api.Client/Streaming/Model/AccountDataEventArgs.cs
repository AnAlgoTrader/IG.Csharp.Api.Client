using System;

namespace IG.Csharp.Api.Client.Streaming.Model
{
    public class AccountDataEventArgs : EventArgs
    {
        public AccountData AccountData { get; }

        public AccountDataEventArgs(AccountData accountData)
        {
            AccountData = accountData;
        }
    }
}