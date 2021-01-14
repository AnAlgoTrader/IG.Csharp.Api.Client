using System;

namespace IG.Csharp.Api.Client.Rest.Model
{
    public class Candle
    {
        public string Market { get; set; }
        public DateTime Date { get; set; }
        public double Open { get; set; }
        public double High { get; set; }
        public double Low { get; set; }
        public double Close { get; set; }
        public double Volume { get; set; }
    }
}
