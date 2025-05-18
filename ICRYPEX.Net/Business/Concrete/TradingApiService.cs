using ICRYPEX.Net.Business.Abstract;
using ICRYPEX.Net.Services;

namespace ICRYPEX.Net.Business.Concrete
{
    internal class TradingApiService : ITradingApiService
    {
        private readonly IcrypexClient _client;
        public TradingApiService(IcrypexClient client)
        {
            _client = client ?? throw new ArgumentNullException(nameof(client));
        }
    }
}
