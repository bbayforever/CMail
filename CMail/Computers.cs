using Newtonsoft.Json;

namespace CMail
{
    public class Computers
    {
        [JsonProperty("id")]
        public string ID { get; set; }
        [JsonProperty("ipaddress")]
        public string IPAdress { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("ping")]
        public string Ping { get; set; }

    }
}
