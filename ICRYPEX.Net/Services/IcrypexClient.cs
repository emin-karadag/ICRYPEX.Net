using ICRYPEX.Net.Business.Abstract;
using ICRYPEX.Net.Business.Concrete;
using System.Net.Http.Json;

namespace ICRYPEX.Net.Services
{
    public class IcrypexClient
    {
        private readonly HttpClient _httpClient;
        private readonly PublicApiService _publicApiService;
        private readonly TradingApiService _tradingApiService;
        private readonly FundingApiService _fundingApiService;
        public IcrypexClient()
        {
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri("https://api.icrypex.com")
            };

            _publicApiService = new PublicApiService(this);
            _tradingApiService = new TradingApiService(this);
            _fundingApiService = new FundingApiService(this);
        }

        public IPublicApiService PublicApi => _publicApiService;

        public async Task<HttpResponseMessage> GetAsync(string endpoint)
        {
            var response = await _httpClient.GetAsync(endpoint);
            return response;
        }

        public async Task<T?> GetFromJsonAsync<T>(string endpoint)
        {
            var response = await _httpClient.GetFromJsonAsync<T>(endpoint);
            return response;
        }

        public async Task<HttpResponseMessage> PostAsync(string endpoint, HttpContent content)
        {
            var response = await _httpClient.PostAsync(endpoint, content);
            return response;
        }

        public async Task<HttpResponseMessage> PutAsync(string endpoint, HttpContent content)
        {
            var response = await _httpClient.PutAsync(endpoint, content);
            return response;
        }

        public async Task<HttpResponseMessage> DeleteAsync(string endpoint)
        {
            var response = await _httpClient.DeleteAsync(endpoint);
            return response;
        }

        public async Task<HttpResponseMessage> PatchAsync(string endpoint, HttpContent content)
        {
            var response = await _httpClient.PatchAsync(endpoint, content);
            return response;
        }

        public async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request)
        {
            var response = await _httpClient.SendAsync(request);
            return response;
        }

    }
}
