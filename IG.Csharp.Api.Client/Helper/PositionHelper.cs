using IG.Csharp.Api.Client.Rest.Model;
using IG.Csharp.Api.Client.Rest.Response;
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
        public static double? CalculatePL(OpenPosition openPosition)
        {
            if (openPosition.Position.Direction == "BUY") return (openPosition.Market.Bid - openPosition.Position.Level) * openPosition.Position.Size;
            else return (openPosition.Position.Level - openPosition.Market.Offer) * openPosition.Position.Size;
        }
        public static void CalculatePL(PositionsResponse positionsResponse)
        {
            positionsResponse.positions.ForEach(openPosition =>
            {
                openPosition.Position.ProfitAndLoss = CalculatePL(openPosition).Value;
            });
        }
        public static double? CalculatePL(OpenPosition openPosition, Streaming.Model.MarketData marketData)
        {
            if (openPosition.Position.Direction == "BUY") return (marketData.Bid - openPosition.Position.Level) * openPosition.Position.Size;
            else return (openPosition.Position.Level - marketData.Offer) * openPosition.Position.Size;
        }
    }
}