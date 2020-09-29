using Newtonsoft.Json;

namespace CMail
{
    class Specialist
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("workname")]
        public string workName { get; set; }

        [JsonProperty("department")]
        public string department { get; set; }
    }
}
