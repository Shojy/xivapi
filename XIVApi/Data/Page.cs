using Newtonsoft.Json;

namespace XIVApi.Data
{
    public class Page<TModel> where TModel : class
    {
        [JsonProperty("Pagination")]
        public Pagination Pagination { get; set; }

        [JsonProperty("Results")]
        public TModel[] Results { get; set; }
    }
}