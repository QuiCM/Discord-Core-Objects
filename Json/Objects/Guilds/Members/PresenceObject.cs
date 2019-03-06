namespace Discord.Json.Objects.Guilds.Members
{
    /// <summary>
    /// Contains data used in a Gateway Status Update request.
    /// The only required field is the ID
    /// </summary>
    public class PresenceObject
    {
        /// <summary>
        /// Partial user field. Will probably only contain ID
        /// </summary>
        public UserObject user;
        /// <summary>
        /// Array of role snowflakes
        /// </summary>
        public string[] roles;
        public Activities.MemberActivityObject game;
        public ulong guild_id;
        public string status;
        public Activities.MemberActivityObject[] activities;
    }
}
