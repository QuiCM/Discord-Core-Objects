using Newtonsoft.Json;

namespace Discord.Json.Commands
{
    public class GatewayResume
    {
        [JsonProperty(Order = 1)]
        public string token;
        [JsonProperty(Order = 2)]
        public string session_id;
        [JsonProperty(Order = 3)]
        public int seq;
    }
}
