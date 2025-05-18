using ICRYPEX.Net.Business.Abstract;
using ICRYPEX.Net.Services;

namespace ICRYPEX.Net.Business.Concrete
{
    internal class FundingApiService : IFundingApiService
    {
        private readonly IcrypexClient _client;
        public FundingApiService(IcrypexClient client)
        {
            _client = client ?? throw new ArgumentNullException(nameof(client));
        }
    }
}
