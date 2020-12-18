using IG.Csharp.Api.Client.Rest.Model;
using IG.Csharp.Api.Client.Rest.Response;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;

namespace IG.Csharp.Api.Client.Helper
{
    public static class PositionHelper
    {
        public static double CalculatePL(TradeSide tradeSide, double size, double level, double buyPrice, double sellPrice)
        {
            if (tradeSide == TradeSide.BUY) return Math.Round((buyPrice - level) * size, 2);
            else return Math.Round((level - sellPrice) * size, 2);
        }
        public static double? CalculatePL(OpenPosition openPosition)
        {
            Contract.Requires(openPosition != null);

            if (openPosition.Position.Direction == "BUY") return (openPosition.Market.Bid - openPosition.Position.Level) * openPosition.Position.Size;
            else return (openPosition.Position.Level - openPosition.Market.Offer) * openPosition.Position.Size;
        }
        public static void CalculatePL(PositionsResponse positionsResponse)
        {
            Contract.Requires(positionsResponse != null);

            positionsResponse.Positions.ForEach(openPosition =>
            {
                openPosition.Position.ProfitAndLoss = CalculatePL(openPosition).Value;
            });
        }
        public static double? CalculatePL(OpenPosition openPosition, Streaming.Model.MarketData marketData)
        {
            Contract.Requires(openPosition != null);
            Contract.Requires(marketData != null);

            if (openPosition.Position.Direction == "BUY") return (marketData.Bid - openPosition.Position.Level) * openPosition.Position.Size;
            else return (openPosition.Position.Level - marketData.Offer) * openPosition.Position.Size;
        }
        public static void CalculatePL(List<OpenPosition> positions, Streaming.Model.MarketData marketData)
        {
            Contract.Requires(positions != null);

            positions.ForEach(position =>
            {
                position.Position.ProfitAndLoss = CalculatePL(position, marketData).Value;
            });
        }
        public static OpenPosition GetLatestPositionBySide(List<OpenPosition> positions, TradeSide tradeSide, string epic)
        {
            var marketPositions = positions.Where(x => x.Position.Direction == tradeSide.ToString() && x.Market.Epic == epic).ToList();
            if (marketPositions.Any())
            {
                return tradeSide == TradeSide.BUY ?
                    marketPositions.OrderBy(x => x.Position.Level).FirstOrDefault() :
                    marketPositions.OrderByDescending(x => x.Position.Level).FirstOrDefault();
            }
            return null;
        }
    }
}