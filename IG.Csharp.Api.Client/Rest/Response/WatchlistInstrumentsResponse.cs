using IG.Csharp.Api.Client.Rest.Model;
using System.Collections.Generic;

namespace IG.Csharp.Api.Client.Rest.Response
{
    public class WatchlistInstrumentsResponse
    {
        ///<Summary>
        ///List of watchlist markets
        ///</Summary>
        public List<WatchlistMarket> markets { get; set; }
    }
}