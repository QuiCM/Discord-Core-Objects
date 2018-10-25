namespace Discord.Json.Objects.Guilds.Members
{
    /// <summary>
    /// Contains data used in a Gateway Voice Status Update request
    /// </summary>
    public class VoiceStateObject
    {
        public ulong guild_id;
        public ulong channel_id;
        /// <summary>
        /// User ID the voice state is for. Not required when sending voice states
        /// </summary>
        public ulong user_id;
        /// <summary>
        /// Session ID for the voice state. Not required when sending voice states
        /// </summary>
        public string session_id;
        /// <summary>
        /// Whether or not the user is server deafened. Not required when sending voice states
        /// </summary>
        public bool deaf;
        /// <summary>
        /// Whether or not the user is server muted. Not required when sending voice states
        /// </summary>
        public bool mute;
        public bool self_deaf;
        public bool self_mute;
        /// <summary>
        /// Whether or not the represented user is muted by our user. Not required when sending voice states
        /// </summary>
        public bool suppress;
    }
}
