using Newtonsoft.Json;

namespace Discord.Descriptors.Commands
{
    public class ResumePayload : Json.Commands.GatewayResume
    {
        [JsonProperty("token")]
        public string Token { get => token; set => token = value; }
        [JsonProperty("session_id")]
        public string Session { get => session_id; set => session_id = value; }
        [JsonProperty("seq")]
        public int Sequence { get => seq; set => seq = value; }
    }
}
