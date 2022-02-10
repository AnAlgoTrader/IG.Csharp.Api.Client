using IG.Csharp.Api.Client.Helper;
using IG.Csharp.Api.Client.Rest.Model;
using IG.Csharp.Api.Client.Rest.Request;
using IG.Csharp.Api.Client.Rest.Response;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Authentication;
using System.Threading;

namespace IG.Csharp.Api.Client.Rest
{
    public class IgRestApiClient : IRestApiClient
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
            _baseUri = $"https://{(environment == "live" ? string.Empty : environment + "-")}api.ig.com";
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
                    client.DefaultRequestHeaders.Add("X-IG-API-KEY", _apiKey);
                    client.DefaultRequestHeaders.Add("VERSION", "2");

                    using (var content = new StringContent(JsonConvert.SerializeObject(authRequest)))
                    {
                        content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                        var response = client.PostAsync(new Uri($"{_baseUri}/{SESSION_URI}"), content).Result;
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
                        else throw new AuthenticationException("Not Authenticated");
                    }
                }
            }
            return _authenticationResponse;
        }
        private bool ShouldAuthenticate() => _authenticationResponse == null ||
                (DateTime.Now - _authenticationResponse.Date).TotalHours >= 5;
        private AuthenticationResponse GetAuthenticationResponseFromDisk()
        {
            try { return JsonConvert.DeserializeObject<AuthenticationResponse>(File.ReadAllText(_username + ".authenticationResponse.json")); }
            catch (FileNotFoundException) { return null; }
        }
        private void SaveAuthentication(AuthenticationResponse authenticationResponse) =>
            File.WriteAllText(_username + ".authenticationResponse.json", JsonConvert.SerializeObject(authenticationResponse));
        private T GetApiResponse<T>(string query, string version)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Add("X-IG-API-KEY", _apiKey);
                    client.DefaultRequestHeaders.Add("VERSION", version);
                    client.DefaultRequestHeaders.Add("CST", _authenticationResponse.Cst);
                    client.DefaultRequestHeaders.Add("X-SECURITY-TOKEN", _authenticationResponse.XSecurityToken);

                    var result = client.GetStringAsync(new Uri($"{_baseUri}/{query}")).Result;
                    return JsonConvert.DeserializeObject<T>(result);
                }
            }
            catch (AggregateException)
            {
                return default(T);
            }
        }

        private T PostApiResponse<T>(string endpoint, string content, string version, string method = null)
        {
            using (var client = new HttpClient())
            {


                client.DefaultRequestHeaders.Add("X-IG-API-KEY", _apiKey);
                client.DefaultRequestHeaders.Add("VERSION", version);
                client.DefaultRequestHeaders.Add("CST", _authenticationResponse.Cst);
                client.DefaultRequestHeaders.Add("X-SECURITY-TOKEN", _authenticationResponse.XSecurityToken);
                if (method != null)
                    client.DefaultRequestHeaders.Add("_method", method);

                using (var stringContent = new StringContent(content))
                {
                    stringContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                    var response = client.PostAsync(new Uri($"{_baseUri}/{endpoint}"), stringContent).Result;
                    var result = response.Content.ReadAsStringAsync().Result;
                    return JsonConvert.DeserializeObject<T>(result);
                }
            }
        }
        public PositionsResponse GetPositions() =>
            GetApiResponse<PositionsResponse>(POSITIONS_URI, "2");
        public ListOfWatchlistsResponse GetWatchLists() =>
            GetApiResponse<ListOfWatchlistsResponse>(WATCHLISTS_URI, "1");
        public AccountDetailsResponse GetAccounts() =>
            GetApiResponse<AccountDetailsResponse>(ACCOUNTS_URI, "1");
        public TradeConfirmResponse GetTradeConfirm(string dealReference) =>
            GetApiResponse<TradeConfirmResponse>(TRADE_CONFIRM_URI + $"/{dealReference}", "1");
        public WatchlistInstrumentsResponse GetInstrumentsByWatchlistId(string watchListId) =>
            GetApiResponse<WatchlistInstrumentsResponse>($"{WATCHLISTS_URI}/{watchListId}", "1");
        public TransactionsResponse GetTransactions(DateTime from)
        {
            var uri = $"{TRANSACTIONS_URI}?from={from:yyyy-MM-dd}";
            return GetApiResponse<TransactionsResponse>(uri, "2");
        }
        public List<Transaction> GetTransactions(DateTime start, DateTime end, TransactionType transactionType)
        {
            var uri = $"{TRANSACTIONS_URI}?type={transactionType}&from={ParseDateToIgFormat(start)}&to={ParseDateToIgFormat(end)}";
            var transactions = new List<Transaction>();
            GetTransactions(transactions, uri, 1);
            return transactions;
        }
        private List<Transaction> GetTransactions(List<Transaction> transactions, string uri, int pageNumber)
        {
            var response = GetApiResponse<TransactionsResponse>($"{uri}&pageNumber={pageNumber}", "2");
            transactions.AddRange(response.Transactions);
            Thread.Sleep(TimeSpan.FromSeconds(5));
            Console.WriteLine($"Handling page number: {response.MetaData.PageData.PageNumber}/{response.MetaData.PageData.TotalPages}");
            if (response.MetaData.PageData.PageNumber < response.MetaData.PageData.TotalPages)
                GetTransactions(transactions, uri, response.MetaData.PageData.PageNumber + 1);
            return transactions;
        }
        public ActivitiesResponse GetActivities(DateTime start, bool detailed) =>
            GetApiResponse<ActivitiesResponse>($"{ACTIVITIES_URI}?from={start:yyyy-MM-dd}&detailed={detailed}", "3");
        public OpenPositionResponse OpenPosition(OpenPositionRequest request)
        {
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
        public ClosePositionResponse ClosePosition(ClosePositionRequest request, string version) =>
            PostApiResponse<ClosePositionResponse>(POSITIONS_OTC_URI, JsonConvert.SerializeObject(request), version, "DELETE");

        public ClosePositionResponse ClosePosition(string dealId, TradeSide tradeSide, double size)
        {
            var request = new ClosePositionRequest
            {
                DealId = dealId,
                Direction = tradeSide == TradeSide.BUY ? TradeSide.SELL.ToString() : TradeSide.BUY.ToString(),
                OrderType = OrderType.MARKET.ToString(),
                Size = size
            };
            return ClosePosition(request, "1");
        }
        public ClosePositionResponse ClosePositionLimit(ClosePositionLimitRequest request, string version) =>
            PostApiResponse<ClosePositionResponse>(POSITIONS_OTC_URI, JsonConvert.SerializeObject(request), version, "DELETE");
        public ClosePositionResponse ClosePositionLimit(string dealId, TradeSide tradeSide, double level, double size)
        {
            var request = new ClosePositionLimitRequest
            {
                DealId = dealId,
                Direction = tradeSide == TradeSide.BUY ? TradeSide.SELL.ToString() : TradeSide.BUY.ToString(),
                Level = level,
                OrderType = OrderType.LIMIT.ToString(),
                Size = size,
                TimeInForce = TimeInForce.FILL_OR_KILL.ToString()
            };
            return ClosePositionLimit(request, "1");
        }
        public TransactionsResponse GetWeekTransactions()
        {
            DateTime startOfWeek = DateTime.Now.StartOfWeek(DayOfWeek.Monday);
            var uri = $"{TRANSACTIONS_URI}/ALL/{startOfWeek:yyyy-MM-dd}/{DateTime.Now:yyyy-MM-dd}";
            return GetApiResponse<TransactionsResponse>(uri, "2");
        }
        public MarketNavigationResponse GetMarketNavigation(string id) =>
            GetApiResponse<MarketNavigationResponse>(MARKET_NAVIGATION_URI + (!string.IsNullOrEmpty(id) ? $"/{id}" : string.Empty), "1");
        public MarketDetailsResponse GetMarketDetails(string epic) =>
            GetApiResponse<MarketDetailsResponse>($"{MARKETS_URI}/{epic}", "3");
        public SearchMarketResponse SearchMarkets(string searchTem) =>
            GetApiResponse<SearchMarketResponse>($"{MARKETS_URI}?searchTerm={WebUtility.UrlEncode(searchTem)}", "1");
        public void SaveHistoricalDataToFile(string epic, Resolution resolution, DateTime from, DateTime to, string filePathToSave)
        {
            var startDate = ParseDateToIgFormat(from);
            var endDate = ParseDateToIgFormat(to);
            var uri = $"{PRICES_URI}/{epic}?resolution={resolution}&from={startDate}&to={endDate}";

            var prices = new List<Price>();
            var response = GetApiResponse<HistoricalPricesResponse>(uri, "3");
            prices.AddRange(response.Prices);

            var totalPages = response.Metadata.PageData.TotalPages;
            if (totalPages > 1)
            {
                for (int page = 2; page <= totalPages; page++)
                {
                    var nextUri = uri + $"&pageNumber={page}";
                    response = GetApiResponse<HistoricalPricesResponse>(nextUri, "3");
                    prices.AddRange(response.Prices);
                }
            }

            File.WriteAllLines(filePathToSave,
                prices.Select(x =>
                $"{x.SnapshotTime},{x.OpenPrice.Ask}, {x.HighPrice.Ask}, {x.LowPrice.Ask}, {x.ClosePrice.Ask}, {x.LastTradedVolume}")
                .ToList());
        }
        private static string ParseDateToIgFormat(DateTime date)
        {
            return date.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture) + "T00%253A00%253A00";
        }

        public void SetCurrentMarketData(Candle data)
        {
            //backtesting method, do not use from this class
            throw new NotImplementedException();
        }

        #region Open Position Examples
        public OpenPositionResponse OpenMarketPosition(string epic, TradeSide side, double size)
        {
            var request = new OpenPositionRequest
            {
                Epic = epic,
                Expiry = "DFB",
                Direction = side.ToString(),
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
        public OpenPositionResponse OpenMarketTrailingPosition(string epic, TradeSide side, double size, double trailingStopIncrement, double stopDistance)
        {
            var request = new OpenPositionRequest
            {
                Epic = epic,
                Expiry = "DFB",
                Direction = side.ToString(),
                Size = size,
                OrderType = "MARKET",
                GuaranteedStop = false,
                TrailingStop = true,
                ForceOpen = true,
                CurrencyCode = "GBP",
                StopDistance = stopDistance,
                TrailingStopIncrement = trailingStopIncrement
            };
            var content = JsonConvert.SerializeObject(request);
            return PostApiResponse<OpenPositionResponse>(POSITIONS_OTC_URI, content, "2");
        }
        #endregion
    }
}