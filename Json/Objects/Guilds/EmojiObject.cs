namespace Discord.Json.Objects.Guilds
{
    public class EmojiObject
    {
        /// <summary>
        /// The Emoji's snowflake ID. Only used for custom emoji
        /// </summary>
        public ulong? id;
        /// <summary>
        /// The Emoji's name
        /// </summary>
        public string name;
        /// <summary>
        /// Roles allowed to use the emoji
        /// </summary>
        public RoleObject[] roles;
        /// <summary>
        /// The user who created the emoji
        /// </summary>
        public UserObject user;
        /// <summary>
        /// Whether or not the emoji must be wrapped in colons
        /// </summary>
        public bool require_colons;
        /// <summary>
        /// Whether or not the emoji is managed by an integration
        /// </summary>
        public bool managed;
        /// <summary>
        /// Whether or not the emoji is animated
        /// </summary>
        public bool animated;
    }
}
