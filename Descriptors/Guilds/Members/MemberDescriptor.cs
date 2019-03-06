using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Discord.Descriptors.Guilds.Members
{
    public class MemberDescriptor : Json.Objects.Guilds.Members.MemberObject
    {
        /// <summary>
        /// The User object related to this member
        /// </summary>
        [JsonProperty("user")]
        public UserDescriptor User { get; set; }
        /// <summary>
        /// Member's nickname, if any
        /// </summary>
        public string Nickname => nick;
        /// <summary>
        /// Roles the member is in
        /// </summary>
        public IEnumerable<RoleDescriptor> Roles { get; set; }
        /// <summary>
        /// Timestamp at which the member joined the guild
        /// </summary>
        public DateTime JoinDate => joined_at;
        /// <summary>
        /// Whether the member is server deafened in voice channels or not
        /// </summary>
        public bool Deafened => deaf;
        /// <summary>
        /// Whether the member is server muted in voice channels or not
        /// </summary>
        public bool Muted => mute;
        /// <summary>
        /// Member's guild. Only set during certain events. Check for null before using
        /// </summary>
        [JsonIgnore]
        public virtual GuildDescriptor Guild { get; set; }
        [JsonIgnore]
        public VoiceStateDescriptor VoiceState { get; set; }
        [JsonIgnore]
        public PresenceDescriptor PresenceState { get; set; }
    }
}
