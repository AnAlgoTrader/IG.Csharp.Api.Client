namespace IG.Csharp.Api.Client.Streaming.Model
{
    public class MarketData
    {
        public double? MidOpen;
        public double? High;
        public double? Low;
        public double? Change;
        public double? ChangePct;
        public string UpdateTime;
        public int? MarketDelay;
        public string MarketState;
        public double? Bid;
        public double? Offer;

        public string Epic { get; set; }
    }
}