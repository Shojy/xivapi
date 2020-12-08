using Newtonsoft.Json;

namespace XIVApi.Data
{
    public class Estate
    {
        [JsonProperty("Greeting")]
        public string Greeting { get; set; }

        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("Plot")]
        public string Plot { get; set; }
    }
}