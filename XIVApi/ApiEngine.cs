using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Newtonsoft.Json;
using XIVApi.Data;

namespace XIVApi
{
    public interface IApiEngine
    {
        Task<FreeCompanySearchResult[]> SearchFreeCompany(string name, Server server = Server.All);
    }

    public class ApiEngine : IApiEngine, IDisposable
    {
        private string _apiKey;
        private HttpClient _client;

        public ApiEngine(string apiKey = null, string apiAddress = null)
        {
            _apiKey = apiKey;
            _client = new HttpClient
            {
                BaseAddress = new Uri(apiAddress ?? "https://xivapi.com/")
            };
        }

        public async Task<FreeCompanySearchResult[]> SearchFreeCompany(string name, Server server = Server.All)
        {
            var searchUri = $"/freecompany/search?name={name}{(server != Server.All? $"&server={server}" : "")}";
            
            var result = await MakeRequest<Page<FreeCompanySearchResult>>(searchUri);
            return result.Results;
        }

        public void Dispose()
        {
            _client?.Dispose();
        }

        private async Task<T> MakeRequest<T>(string uri)
        {
            var json = await _client.GetStringAsync(uri);
            return JsonConvert.DeserializeObject<T>(json);
        }
    }
}
