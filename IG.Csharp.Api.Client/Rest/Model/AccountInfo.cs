namespace IG.Csharp.Api.Client.Rest.Model
{
    public class AccountInfo
    {
        ///<Summary>
        ///Balance of funds in the account
        ///</Summary>
        public double balance { get; set; }
        ///<Summary>
        ///Minimum deposit amount required for margins
        ///</Summary>
        public double deposit { get; set; }
        ///<Summary>
        ///Account profit and loss amount
        ///</Summary>
        public double profitLoss { get; set; }
        ///<Summary>
        ///Account funds available for trading amount
        ///</Summary>
        public double available { get; set; }
    }
}
