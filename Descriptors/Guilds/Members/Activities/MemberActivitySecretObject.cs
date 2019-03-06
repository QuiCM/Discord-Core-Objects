using Newtonsoft.Json;

namespace Discord.Descriptors.Guilds.Members.Activities
{
    public class MemberActivitySecretObject
    {
        [JsonProperty("join")]
        public string Join { get; set; }
        [JsonProperty("spectate")]
        public string Spectate { get; set; }
        [JsonProperty("match")]
        public string Match { get; set; }
    }
}