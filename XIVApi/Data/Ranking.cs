using Newtonsoft.Json;

namespace XIVApi.Data
{
    public class Ranking
    {
        [JsonProperty("Monthly")]
        public long Monthly { get; set; }

        [JsonProperty("Weekly")]
        public string Weekly { get; set; }
    }
}