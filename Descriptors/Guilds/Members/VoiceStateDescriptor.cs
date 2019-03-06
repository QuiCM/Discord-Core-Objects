using Newtonsoft.Json;

namespace Discord.Descriptors.Guilds.Members
{
    public class VoiceStateDescriptor : Json.Objects.Guilds.Members.VoiceStateObject
    {
        [JsonIgnore]
        public virtual GuildDescriptor Guild { get; set; }
        [JsonIgnore]
        public Channels.VoiceChannelDescriptor Channel { get; set; }
        public UserDescriptor User { get; set; }
        public string Session => session_id;
        public bool Deafened => deaf;
        public bool Muted => mute;
        public bool SelfDeafened => self_deaf;
        public bool SelfMuted => self_mute;
        public bool Suppressed => suppress; 
    }
}
