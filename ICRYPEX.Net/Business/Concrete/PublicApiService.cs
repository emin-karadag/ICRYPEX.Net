using ICRYPEX.Net.Business.Abstract;
using ICRYPEX.Net.Core.Enums;
using ICRYPEX.Net.Core.Helpers;
using ICRYPEX.Net.Models.Public;
using ICRYPEX.Net.Services;
using static ICRYPEX.Net.Models.Public.KLine;

namespace ICRYPEX.Net.Business.Concrete
{
    internal class PublicApiService : IPublicApiService
    {
        private readonly IcrypexClient _client;
        public PublicApiService(IcrypexClient client)
        {
            _client = client ?? throw new ArgumentNullException(nameof(client));
        }

        public async Task<ExchangeInfo?> GetExchangeInfoAsync()
        {
            var endpoint = "/v1/exchange/info";
            var response = await _client.GetFromJsonAsync<ExchangeInfo>(endpoint);
            return response;
        }

        public async Task<List<Ticker>?> GetTickersAsync()
        {
            var endpoint = "/v1/tickers";
            var response = await _client.GetFromJsonAsync<List<Ticker>>(endpoint);
            return response;
        }

        public async Task<OrderBook?> GetOrderBookAsync(string symbol)
        {
            var endpoint = $"/v1/orderbook?symbol={symbol}";
            var response = await _client.GetFromJsonAsync<OrderBook>(endpoint);
            return response;
        }

        public async Task<LastTrade?> GetLastTradesAsync(string symbol)
        {
            var endpoint = $"/v1/trades/last?symbol={symbol}";
            var response = await _client.GetFromJsonAsync<LastTrade>(endpoint);
            return response;
        }

        public async Task<List<KLineData>> GetKlineDataAsync(string symbol, DateTime fromDate, DateTime toDate, KLineResolutionEnum resolution)
        {
            var resolutionStr = resolution switch
            {
                KLineResolutionEnum.OneDay => "1D",
                KLineResolutionEnum.ThreeDays => "3D",
                KLineResolutionEnum.OneWeek => "1W",
                KLineResolutionEnum.OneMonth => "1M",
                _ => ((int)resolution).ToString()
            };

            var (from, to) = UnixTimeHelper.ToUnixRange(fromDate, toDate);
            var endpoint = $"/sapi/v1/trades/kline?symbol={symbol}&from={from}&to={to}&resolution={resolutionStr}";
            var response = await _client.GetFromJsonAsync<KLine>(endpoint);

            var candlesticks = new List<KLineData>();
            if (response is not null)
            {
                for (int i = 0; i < response.Timestamps.Length; i++)
                {
                    candlesticks.Add(new KLineData
                    {
                        Timestamp = UnixTimeHelper.FromUnixTimestamp(response.Timestamps[i]),
                        Open = response.OpenPrices[i],
                        High = response.HighPrices[i],
                        Low = response.LowPrices[i],
                        Close = response.ClosePrices[i],
                        Volume = response.Volumes[i]
                    });
                }
            }

            return candlesticks;
        }
    }
}
