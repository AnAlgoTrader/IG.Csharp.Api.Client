using System;
using System.Collections.Generic;
using IG.Csharp.Api.Client.Rest.Model;
using IG.Csharp.Api.Client.Rest.Request;
using IG.Csharp.Api.Client.Rest.Response;

namespace IG.Csharp.Api.Client.Rest
{
    public class BackTestingClient : IRestApiClient
    {
        public BackTestingClient()
        {
        }

        public AuthenticationResponse Authenticate()
        {
            throw new NotImplementedException();
        }

        public ClosePositionResponse ClosePosition(ClosePositionRequest request, string version)
        {
            throw new NotImplementedException();
        }

        public ClosePositionResponse ClosePosition(string dealId, TradeSide tradeSide, double size)
        {
            throw new NotImplementedException();
        }

        public ClosePositionResponse ClosePositionLimit(ClosePositionLimitRequest request, string version)
        {
            throw new NotImplementedException();
        }

        public ClosePositionResponse ClosePositionLimit(string dealId, TradeSide tradeSide, double level, double size)
        {
            throw new NotImplementedException();
        }

        public CreateWorkingOrderResponse CreateWorkingOrder(string epic, string side, double size, double level, bool guaranteedStop = false, double? stopDistance = null)
        {
            throw new NotImplementedException();
        }

        public AccountDetailsResponse GetAccounts()
        {
            throw new NotImplementedException();
        }

        public T GetApiResponse<T>(string query, string version)
        {
            throw new NotImplementedException();
        }

        public AuthenticationResponse GetAuthenticationResponseFromDisk()
        {
            throw new NotImplementedException();
        }

        public WatchlistInstrumentsResponse GetInstrumentsByWatchlistId(string watchListId)
        {
            throw new NotImplementedException();
        }

        public MarketDetailsResponse GetMarketDetails(string epic)
        {
            throw new NotImplementedException();
        }

        public MarketNavigationResponse GetMarketNavigation(string id)
        {
            throw new NotImplementedException();
        }

        public PositionsResponse GetPositions()
        {
            throw new NotImplementedException();
        }

        public TradeConfirmResponse GetTradeConfirm(string dealReference)
        {
            throw new NotImplementedException();
        }

        public TransactionsResponse GetTransactions(DateTime from)
        {
            throw new NotImplementedException();
        }

        public List<Transaction> GetTransactions(DateTime from, TransactionType transactionType)
        {
            throw new NotImplementedException();
        }

        public ListOfWatchlistsResponse GetWatchLists()
        {
            throw new NotImplementedException();
        }

        public TransactionsResponse GetWeekTransactions()
        {
            throw new NotImplementedException();
        }

        public OpenPositionResponse OpenMarketPosition(string epic, string side, double size)
        {
            throw new NotImplementedException();
        }

        public T PostApiResponse<T>(string endpoint, string content, string version, string method = null)
        {
            throw new NotImplementedException();
        }

        public void SaveAuthentication(AuthenticationResponse authenticationResponse)
        {
            throw new NotImplementedException();
        }

        public void SavePriceDataToFile(string epic, Resolution resolution, DateTime fromDate, DateTime toDate, string filePathToSave)
        {
            throw new NotImplementedException();
        }

        public SearchMarketResponse SearchMarkets(string searchTem)
        {
            throw new NotImplementedException();
        }

        public bool ShouldAuthenticate()
        {
            throw new NotImplementedException();
        }
    }
}
