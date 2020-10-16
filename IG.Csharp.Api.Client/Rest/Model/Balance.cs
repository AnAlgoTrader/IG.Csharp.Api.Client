using System;
using System.Collections.Generic;
using System.Text;

namespace IG.Csharp.Api.Client.Rest.Model
{
    public class Balance
    {
        public double balance { get; set; }
        public double deposit { get; set; }
        public double profitLoss { get; set; }
        public double available { get; set; }
    }
}
