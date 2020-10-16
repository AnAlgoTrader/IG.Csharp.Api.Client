using IG.Csharp.Api.Client.Rest.Model;
using System;

namespace IG.Csharp.Api.Client.Helper
{
    public class PositionHelper
    {
        public static double CalculatePL(TradeSide tradeSide, double size, double level, double buyPrice, double sellPrice)
        {
            if (tradeSide == TradeSide.BUY) return Math.Round((buyPrice - level) * size, 2);
            else return Math.Round((level - sellPrice) * size, 2);
        }
        public static double? CalculatePL(OpenPosition position)
        {
            if (position.position.direction == "BUY") return (position.market.bid - position.position.level) * position.position.size;
            else return (position.position.level - position.market.offer) * position.position.size;
        }

        public static double? CalculatePL(OpenPosition position, Streaming.Model.MarketData marketData)
        {
            if (position.position.direction == "BUY") return (marketData.Bid - position.position.level) * position.position.size;
            else return (position.position.level - marketData.Offer) * position.position.size;
        }
    }
}