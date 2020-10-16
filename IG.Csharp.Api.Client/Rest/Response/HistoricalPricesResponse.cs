using System;

namespace IG.Csharp.Api.Client.Rest.Response
{
    public class HistoricalPricesResponse
    {
        public Price[] prices { get; set; }
        public string instrumentType { get; set; }
        public Metadata metadata { get; set; }
    }

    public class Metadata
    {
        public Allowance allowance { get; set; }
        public int size { get; set; }
        public Pagedata pageData { get; set; }
    }

    public class Allowance
    {
        public int remainingAllowance { get; set; }
        public int totalAllowance { get; set; }
        public int allowanceExpiry { get; set; }
    }

    public class Pagedata
    {
        public int pageSize { get; set; }
        public int pageNumber { get; set; }
        public int totalPages { get; set; }
    }

    public class Price
    {
        public string snapshotTime { get; set; }
        public DateTime snapshotTimeUTC { get; set; }
        public Openprice openPrice { get; set; }
        public Closeprice closePrice { get; set; }
        public Highprice highPrice { get; set; }
        public Lowprice lowPrice { get; set; }
        public int lastTradedVolume { get; set; }
    }

    public class Openprice
    {
        public float bid { get; set; }
        public float ask { get; set; }
        public object lastTraded { get; set; }
    }

    public class Closeprice
    {
        public float bid { get; set; }
        public float ask { get; set; }
        public object lastTraded { get; set; }
    }

    public class Highprice
    {
        public float bid { get; set; }
        public float ask { get; set; }
        public object lastTraded { get; set; }
    }

    public class Lowprice
    {
        public float bid { get; set; }
        public float ask { get; set; }
        public object lastTraded { get; set; }
    }
}
