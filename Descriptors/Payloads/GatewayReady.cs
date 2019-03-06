using Discord.Descriptors.Channels;
using Discord.Descriptors.Guilds;
using Discord.Json.Payloads;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Discord.Descriptors.Payloads
{
    public class GatewayReady : ReadyEvent
    {
        [JsonProperty("v")]
        public int Version { get => v; set => v = value; }
        [JsonProperty("user")]
        public UserDescriptor User { get; set; }
        [JsonProperty("guilds")]
        public IEnumerable<GuildDescriptor> Guilds { get; set; }
        [JsonProperty("session_id")]
        public string Session { get => session_id; set => session_id = value; }
        [JsonProperty("_trace")]
        public string[] Trace { get => _trace; set => _trace = value; }
    }
}
