using System;
using Newtonsoft.Json;

namespace XIVApi.Data
{
    public class FreeCompany
    {
        [JsonProperty("Active")]
        public string Active { get; set; }

        [JsonProperty("ActiveMemberCount")]
        public long ActiveMemberCount { get; set; }

        [JsonProperty("Crest")]
        public Uri[] Crest { get; set; }

        [JsonProperty("DC")]
        public DataCenter Dc { get; set; }

        [JsonProperty("Estate")]
        public Estate Estate { get; set; }

        [JsonProperty("Focus")]
        public Focus[] Focus { get; set; }

        [JsonProperty("Formed")]
        public long Formed { get; set; }

        [JsonProperty("GrandCompany")]
        public string GrandCompany { get; set; }

        [JsonProperty("ID")]
        public string Id { get; set; }

        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("ParseDate")]
        public long ParseDate { get; set; }

        [JsonProperty("Rank")]
        public long Rank { get; set; }

        [JsonProperty("Ranking")]
        public Ranking Ranking { get; set; }

        [JsonProperty("Recruitment")]
        public string Recruitment { get; set; }

        [JsonProperty("Reputation")]
        public Reputation[] Reputation { get; set; }

        [JsonProperty("Seeking")]
        public object[] Seeking { get; set; }

        [JsonProperty("Server")]
        public string Server { get; set; }

        [JsonProperty("Slogan")]
        public string Slogan { get; set; }

        [JsonProperty("Tag")]
        public string Tag { get; set; }
    }
}