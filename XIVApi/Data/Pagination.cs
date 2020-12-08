using Newtonsoft.Json;

namespace XIVApi.Data
{
    public class Pagination
    {
        [JsonProperty("Page")]
        public int Page { get; set; }

        [JsonProperty("PageNext")]
        public int? PageNext { get; set; }

        [JsonProperty("PagePrev")]
        public int? PagePrev { get; set; }

        [JsonProperty("PageTotal")]
        public int PageTotal { get; set; }

        [JsonProperty("Results")]
        public int Results { get; set; }

        [JsonProperty("ResultsPerPage")]
        public int ResultsPerPage { get; set; }

        [JsonProperty("ResultsTotal")]
        public int ResultsTotal { get; set; }
    }
}