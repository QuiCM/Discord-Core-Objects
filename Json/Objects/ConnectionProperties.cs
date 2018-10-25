using Newtonsoft.Json;

namespace Discord.Json.Objects
{
    public struct ConnectionProperties
    {
        [JsonProperty("$os")]
        public string os;
        [JsonProperty("$browser")]
        public string browser;
        [JsonProperty("$device")]
        public string device;
    }
}
