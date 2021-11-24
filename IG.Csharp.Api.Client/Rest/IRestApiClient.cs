using IG.Csharp.Api.Client.Rest.Model;
using IG.Csharp.Api.Client.Rest.Request;
using IG.Csharp.Api.Client.Rest.Response;
using System;
using System.Collections.Generic;

namespace IG.Csharp.Api.Client.Rest
{
    public interface IRestApiClient
    {
        AuthenticationResponse Authenticate();
        PositionsResponse GetPositions();
        ListOfWatchlistsResponse GetWatchLists();
        AccountDetailsResponse GetAccounts();
        TradeConfirmResponse GetTradeConfirm(string dealReference);
        WatchlistInstrumentsResponse GetInstrumentsByWatchlistId(string watchListId);
        TransactionsResponse GetTransactions(DateTime start);
        List<Transaction> GetTransactions(DateTime startTime, DateTime endTime, TransactionType transactionType);
        OpenPositionResponse OpenMarketPosition(string epic, string side, double size);
        CreateWorkingOrderResponse CreateWorkingOrder(string epic, string side, double size, double level,
            bool guaranteedStop = false, double? stopDistance = null);
        ClosePositionResponse ClosePosition(ClosePositionRequest request, string version);
        ClosePositionResponse ClosePosition(string dealId, TradeSide tradeSide, double size);
        ClosePositionResponse ClosePositionLimit(ClosePositionLimitRequest request, string version);
        ClosePositionResponse ClosePositionLimit(string dealId, TradeSide tradeSide, double level, double size);
        TransactionsResponse GetWeekTransactions();
        MarketNavigationResponse GetMarketNavigation(string id);
        MarketDetailsResponse GetMarketDetails(string epic);
        SearchMarketResponse SearchMarkets(string searchTem);
        ActivitiesResponse GetActivities(DateTime from, bool detailed);

        #region BackTesting
        void SetCurrentMarketData(Candle data);
        #endregion
    }
}