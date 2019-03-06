using Newtonsoft.Json;

namespace Discord.Descriptors.Commands
{
    public class ResumePayload : Json.Commands.GatewayResume
    {
        [JsonIgnore]
        public string Token => token;
        [JsonIgnore]
        public string Session => session_id;
        [JsonIgnore]
        public int Sequence => seq;
    }
}
