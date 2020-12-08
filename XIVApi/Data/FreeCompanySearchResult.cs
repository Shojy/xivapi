using System;
using Newtonsoft.Json;

namespace XIVApi.Data
{
    public class FreeCompanySearchResult
    {
        [JsonProperty("Crest")]
        public Uri[] Crest { get; set; }

        [JsonProperty("ID")]
        public string Id { get; set; }

        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("Server")]
        public Server Server { get; set; }
    }
}