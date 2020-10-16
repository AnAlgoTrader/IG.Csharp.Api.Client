namespace IG.Csharp.Api.Client.Rest.Model
{
    public class AccountDetails
    {
        public string accountId { get; set; }
        public string accountName { get; set; }
        public bool preferred { get; set; }
        public string accountType { get; set; }
        public Balance balance { get; set; }
    }
}
