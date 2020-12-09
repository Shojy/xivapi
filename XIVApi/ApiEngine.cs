using System;
using System.Threading.Tasks;
using XIVApi.Data;

namespace XIVApi
{
    public interface IApiEngine
    {

    }

    public class ApiEngine : IApiEngine
    {
        public string ApiKey { get; }

        public ApiEngine(string apiKey = null)
        {
            ApiKey = apiKey;
        }

        public Task<FreeCompanySearchResult[]> SearchFreeCompany(string name, Server server = Server.All)
        {
            return null;
        }
    }
}
