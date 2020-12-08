using System;
using Newtonsoft.Json;

namespace XIVApi.Data
{
    public class Focus
    {
        [JsonProperty("Icon")]
        public Uri Icon { get; set; }

        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("Status")]
        public bool Status { get; set; }
    }
}