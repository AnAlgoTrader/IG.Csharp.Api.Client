namespace IG.Csharp.Api.Client
{
    public enum StreamingDirection
    {
        BUY,
        SELL
    }
    public enum StreamingStatus
    {
        OPEN,
        OPENED,
        UPDATED,
        AMENDED,
        CLOSED,
        DELETED,
        PARTIALLY_CLOSED,
        FULLY_CLOSED
    }
    public enum StreamingDealStatus
    {
        ACCEPTED,
        REJECTED,

    }
    public enum ChartScale
    {
        OneSecond,
        OneMinute,
        FiveMinute,
        OneHour,
    }

    public enum TradeSubscriptionType
    {
        Opu = 0,
        Wou = 1,
        Confirm = 2
    }

    public enum MarketStatus
    {
        OFFLINE,
        CLOSED,
        SUSPENDED,
        ON_AUCTION,
        ON_AUCTION_NO_EDITS,
        EDITS_ONLY,
        TRADEABLE,
    }

    public enum AccountType
    {
        SPREADBET
    }

    public enum CandleColor
    {
        RED,
        GREEN,
        GRAY
    }
    public enum Resolution
    {
        SECOND,
        MINUTE,
        MINUTE_2,
        MINUTE_3,
        MINUTE_5,
        MINUTE_10,
        MINUTE_15,
        MINUTE_30,
        HOUR,
        HOUR_2,
        HOUR_3,
        HOUR_4,
        DAY,
        WEEK,
        MONTH
    }
    public enum TradeSide
    {
        BUY,
        SELL,
        NONE
    }
    public enum TimeInForce
    {
        EXECUTE_AND_ELIMINATE,
        FILL_OR_KILL,
        GOOD_TILL_CANCELLED,
        GOOD_TILL_DATE
    }
    public enum OrderType
    {
        LIMIT,
        STOP,
        MARKET
    }

    public enum TransactionType
    {
        ALL,
        ALL_DEAL,
        DEPOSIT,
        WITHDRAWAL
    }
}
