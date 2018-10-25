using System;

namespace Discord.Json.Objects.Guilds.Members
{
    /// <summary>
    /// Data for a Guild Member object. Received during various events
    /// </summary>
    public class MemberObject
    {
        /// <summary>
        /// The User object related to this member
        /// </summary>
        public UserObject user;
        /// <summary>
        /// Member's nickname, if any
        /// </summary>
        public string nick;
        /// <summary>
        /// Roles the member is in
        /// </summary>
        public ulong[] roles;
        /// <summary>
        /// Timestamp at which the member joined the guild
        /// </summary>
        public DateTime joined_at;
        /// <summary>
        /// Whether the member is server deafened in voice channels or not
        /// </summary>
        public bool deaf;
        /// <summary>
        /// Whether the member is server muted in voice channels or not
        /// </summary>
        public bool mute;
        /// <summary>
        /// Guild Snowflake ID. Only set during certain events. Check for null before using
        /// </summary>
        public ulong? guild_id;
    }
}
