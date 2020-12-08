using Newtonsoft.Json;

namespace XIVApi.Data
{
    public class Reputation
    {
        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("Progress")]
        public long Progress { get; set; }

        [JsonProperty("Rank")]
        public string Rank { get; set; }
    }
}