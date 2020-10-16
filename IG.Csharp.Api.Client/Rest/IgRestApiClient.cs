using IG.Csharp.Api.Client.Helper;
using IG.Csharp.Api.Client.Rest.Model;
using IG.Csharp.Api.Client.Rest.Request;
using IG.Csharp.Api.Client.Rest.Response;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;

namespace IG.Csharp.Api.Client.Rest
{
    public class IgRestApiClient
    {
        private readonly string _baseUri;
        private readonly string _username;
        private readonly string _password;
        private readonly string _apiKey;
        private const string SESSION_URI = "/gateway/deal/session";
        private const string WATCHLISTS_URI = "/gateway/deal/watchlists";
        private const string POSITIONS_URI = "/gateway/deal/positions";
        private const string ACCOUNTS_URI = "/gateway/deal/accounts";
        private const string TRANSACTIONS_URI = "/gateway/deal/history/transactions";
        private const string ACTIVITIES_URI = "/gateway/deal/history/activity";
        private const string POSITIONS_OTC_URI = "/gateway/deal/positions/otc";
        private const string PRICES_URI = "/gateway/deal/prices";
        private const string MARKET_NAVIGATION_URI = "/gateway/deal/marketnavigation";
        private const string TRADE_CONFIRM_URI = "/gateway/deal/confirms";
        private const string WORKING_ORDERS_URI = "/gateway/deal/workingorders/otc";
        private const string MARKETS_URI = "/gateway/deal/markets";
        private AuthenticationResponse _authenticationResponse;

        public IgRestApiClient(string environment, string username, string password, string apiKey)
        {
            _username = username;
            _password = password;
            _apiKey = apiKey;
            _baseUri = string.Format("https://{0}api.ig.com", environment == "live" ? "" : environment + "-");
        }
        public AuthenticationResponse Authenticate()
        {
            _authenticationResponse = GetAuthenticationResponseFromDisk();

            if (ShouldAuthenticate())
            {
                var authRequest = new AuthenticationRequest
                {
                    identifier = _username,
                    password = _password
                };

                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(_baseUri);
                    client.DefaultRequestHeaders.Add("X-IG-API-KEY", _apiKey);
                    client.DefaultRequestHeaders.Add("VERSION", "2");

                    var content = new StringContent(JsonConvert.SerializeObject(authRequest));
                    content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                    var response = client.PostAsync(SESSION_URI, content).Result;
                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        var result = response.Content.ReadAsStringAsync().Result;
                        _authenticationResponse = JsonConvert.DeserializeObject<AuthenticationResponse>(result);

                        _authenticationResponse.Cst = response.Headers.FirstOrDefault(x => x.Key == "CST").Value.First();
                        _authenticationResponse.XSecurityToken = response.Headers.FirstOrDefault(x => x.Key == "X-SECURITY-TOKEN").Value.First();
                        _authenticationResponse.ApiKey = _apiKey;
                        _authenticationResponse.Date = DateTime.Now;
                        SaveAuthentication(_authenticationResponse);
                    }
                    else throw new Exception("Not Authenticated");
                }
            }            
            return _authenticationResponse;
        }      
        private bool ShouldAuthenticate()
        {
            return
                _authenticationResponse == null ||
                (DateTime.Now - _authenticationResponse.Date).TotalHours >= 5;
        }
        private AuthenticationResponse GetAuthenticationResponseFromDisk()
        {
            try { return JsonConvert.DeserializeObject<AuthenticationResponse>(File.ReadAllText("authenticationResponse.json")); }
            catch (FileNotFoundException) { return null; }
        }
        private void SaveAuthentication(AuthenticationResponse authenticationResponse)
        {
            File.WriteAllText("authenticationResponse.json", JsonConvert.SerializeObject(authenticationResponse));
        }
        private T GetApiResponse<T>(string query, string version)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(_baseUri);
                client.DefaultRequestHeaders.Add("X-IG-API-KEY", _apiKey);
                client.DefaultRequestHeaders.Add("VERSION", version);
                client.DefaultRequestHeaders.Add("CST", _authenticationResponse.Cst);
                client.DefaultRequestHeaders.Add("X-SECURITY-TOKEN", _authenticationResponse.XSecurityToken);

                var result = client.GetStringAsync(query).Result;
                return JsonConvert.DeserializeObject<T>(result);
            }
        }
        private T PostApiResponse<T>(string endpoint, string content, string version, string method = null)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(_baseUri);
                client.DefaultRequestHeaders.Add("X-IG-API-KEY", _apiKey);
                client.DefaultRequestHeaders.Add("VERSION", version);
                client.DefaultRequestHeaders.Add("CST", _authenticationResponse.Cst);
                client.DefaultRequestHeaders.Add("X-SECURITY-TOKEN", _authenticationResponse.XSecurityToken);
                if (method != null)
                    client.DefaultRequestHeaders.Add("_method", method);

                var stringContent = new StringContent(content);
                stringContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                var response = client.PostAsync(endpoint, stringContent).Result;
                var result = response.Content.ReadAsStringAsync().Result;
                return JsonConvert.DeserializeObject<T>(result);
            }
        }
        public PositionsResponse GetPositions()
        {
            return GetApiResponse<PositionsResponse>(POSITIONS_URI, "2");
        }
        public ListOfWatchlistsResponse GetWatchLists()
        {
            return GetApiResponse<ListOfWatchlistsResponse>(WATCHLISTS_URI, "1");
        }
        public AccountDetailsResponse GetAccounts()
        {
            return GetApiResponse<AccountDetailsResponse>(ACCOUNTS_URI, "1");
        }
        public TradeConfirmResponse GetTradeConfirm(string dealReference)
        {
            var uri = TRADE_CONFIRM_URI + $"/{dealReference}";
            return GetApiResponse<TradeConfirmResponse>(uri, "1");
        }
        public WatchlistInstrumentsResponse GetInstrumentsByWatchlistId(string watchListId)
        {
            var query = $"{WATCHLISTS_URI}/{watchListId}";
            return GetApiResponse<WatchlistInstrumentsResponse>(query, "1");
        }
        public TransactionsResponse GetTransactions(DateTime from)
        {
            var uri = $"{TRANSACTIONS_URI}?from={from:yyyy-MM-dd}";
            return GetApiResponse<TransactionsResponse>(uri, "2");
        }
        public List<Transaction> GetTransactions(DateTime from, TransactionType transactionType)
        {
            var uri = $"{TRANSACTIONS_URI}?type={transactionType}&from={from:yyyy-MM-dd}";
            var transactions = new List<Transaction>();
            GetTransactions(transactions, uri, 1);
            return transactions;
        }
        private List<Transaction> GetTransactions(List<Transaction> transactions, string uri, int pageNumber)
        {
            var response = GetApiResponse<TransactionsResponse>($"{uri}&pageNumber={pageNumber}", "2");
            transactions.AddRange(response.Transactions);
            Thread.Sleep(TimeSpan.FromSeconds(1));
            if (response.Metadata.pageData.pageNumber < response.Metadata.pageData.totalPages)
                GetTransactions(transactions, uri, response.Metadata.pageData.pageNumber + 1);
            return transactions;
        }
        public ActivitiesResponse GetActivities(DateTime from)
        {
            var uri = $"{ACTIVITIES_URI}?from={from:yyyy-MM-dd}";
            return GetApiResponse<ActivitiesResponse>(uri, "3");
        }
        public OpenPositionResponse OpenMarketPosition(string epic, string side, double size)
        {
            var request = new OpenPositionRequest
            {
                Epic = epic,
                Expiry = "DFB",
                Direction = side,
                Size = size,
                OrderType = "MARKET",
                GuaranteedStop = false,
                TrailingStop = false,
                ForceOpen = true,
                CurrencyCode = "GBP"
            };
            var content = JsonConvert.SerializeObject(request);
            return PostApiResponse<OpenPositionResponse>(POSITIONS_OTC_URI, content, "2");
        }
        public CreateWorkingOrderResponse CreateWorkingOrder(
            string epic, string side, double size, double level,
            bool guaranteedStop = false, double? stopDistance = null)
        {
            var request = new CreateWorkingOrderRequest
            {
                Epic = epic,
                Direction = side,
                Expiry = "DFB",
                Size = size,
                TimeInForce = TimeInForce.GOOD_TILL_CANCELLED.ToString(),
                CurrencyCode = "GBP",
                GuaranteedStop = guaranteedStop,
                StopDistance = stopDistance,
                Type = OrderType.LIMIT.ToString(),
                Level = level,
                ForceOpen = true
            };
            var content = JsonConvert.SerializeObject(request);
            return PostApiResponse<CreateWorkingOrderResponse>(WORKING_ORDERS_URI, content, "2");
        }
        public ClosePositionResponse ClosePosition(ClosePositionRequest request, string version)
        {
            var content = JsonConvert.SerializeObject(request);
            return PostApiResponse<ClosePositionResponse>(POSITIONS_OTC_URI, content, version, "DELETE");
        }
        public ClosePositionResponse ClosePositionLimit(ClosePositionLimitRequest request, string version)
        {
            var content = JsonConvert.SerializeObject(request);
            return PostApiResponse<ClosePositionResponse>(POSITIONS_OTC_URI, content, version, "DELETE");
        }
        public TransactionsResponse GetWeekTransactions()
        {
            DateTime startOfWeek = DateTime.Now.StartOfWeek(DayOfWeek.Monday);
            var uri = $"{TRANSACTIONS_URI}/ALL/{startOfWeek.ToString("yyyy-MM-dd")}/{DateTime.Now.ToString("yyyy-MM-dd")}";
            return GetApiResponse<TransactionsResponse>(uri, "2");
        }
        public MarketNavigationResponse GetMarketNavigation(string id)
        {
            var uri = MARKET_NAVIGATION_URI + (!string.IsNullOrEmpty(id) ? $"/{id}" : string.Empty);
            return GetApiResponse<MarketNavigationResponse>(uri, "1");
        }
        public MarketDetailsResponse GetMarketDetails(string epic)
        {
            var uri = $"{MARKETS_URI}/{epic}";
            return GetApiResponse<MarketDetailsResponse>(uri, "3");
        }
        public SearchMarketResponse SearchMarkets(string searchTem)
        {
            var uri = $"{MARKETS_URI}?searchTerm={WebUtility.UrlEncode(searchTem)}";
            return GetApiResponse<SearchMarketResponse>(uri, "1");
        }        
        public void SavePriceDataToFile(string epic, Resolution resolution, DateTime from, DateTime to, string filePathToSave)
        {
            var startDate = from.ToString("yyyy-MM-dd") + "T00%3A00%3A00";
            var endDate = to.ToString("yyyy-MM-dd") + "T00%3A00%3A00";
            var uri = $"{PRICES_URI}/{epic}?resolution={resolution}&from={startDate}&to={endDate}";

            var response = GetApiResponse<HistoricalPricesResponse>(uri, "3");
            File.WriteAllLines(filePathToSave,
                response.prices.Select(x =>
                $"{x.snapshotTime},{x.openPrice.ask},{x.openPrice.bid}")
                .ToList());
        }
    }
}