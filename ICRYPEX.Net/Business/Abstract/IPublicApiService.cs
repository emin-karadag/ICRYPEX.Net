using ICRYPEX.Net.Core.Enums;
using ICRYPEX.Net.Models.Public;
using static ICRYPEX.Net.Models.Public.KLine;

namespace ICRYPEX.Net.Business.Abstract
{
    public interface IPublicApiService
    {
        /// <summary>
        /// Exchange Info endpoint returns all assets and pairs in Icrypex.
        /// </summary>
        /// <returns></returns>
        Task<ExchangeInfo?> GetExchangeInfoAsync();

        /// <summary>
        /// Returns all ticker data.
        /// </summary>
        /// <returns></returns>
        Task<List<Ticker>?> GetTickersAsync();

        /// <summary>
        /// Order book endpoints returns best ask and bid orders of a pair. Returns maximum 50 rows for each side.
        /// </summary>
        /// <param name="symbol">Pair symbol in BTCUSDT format</param>
        /// <returns></returns>
        Task<OrderBook?> GetOrderBookAsync(string symbol);

        /// <summary>
        /// Last Trades endpoint returns last trades of a pair. That endpoint returns maximum last 50 trades.
        /// </summary>
        /// <param name="symbol">Pair symbol in BTCUSDT format</param>
        /// <returns></returns>
        Task<LastTrade?> GetLastTradesAsync(string symbol);

        /// <summary>
        /// K-line data is a public endpoint. It requires some parameters to get the data.
        /// </summary>
        /// <param name="symbol">Pair symbol in BTCUSDT format</param>
        /// <param name="fromDate">Start time in unix seconds</param>
        /// <param name="toDate">End time in unix seconds</param>
        /// <param name="resolution">Resolution for the data. For minutes; 1,5,15,60,240. For daily 1D, for weekly 1W.</param>
        /// <returns></returns>
        Task<List<KLineData>> GetKlineDataAsync(string symbol, DateTime fromDate, DateTime toDate, KLineResolutionEnum resolution);
    }
}
