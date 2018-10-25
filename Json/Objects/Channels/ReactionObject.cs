namespace Discord.Json.Objects.Channels
{
    /// <summary>
    /// Json data sent when an <see cref="EmojiObject"/> is added to a message
    /// </summary>
    public class ReactionObject
    {
        /// <summary>
        /// The user who added the reaction
        /// </summary>
        public ulong user_id;
        /// <summary>
        /// The message the reaction was added to
        /// </summary>
        public ulong message_id;
        /// <summary>
        /// The channel the Message was sent in
        /// </summary>
        public ulong channel_id;
        /// <summary>
        /// The emoji used in the reaction
        /// </summary>
        public Guilds.EmojiObject emoji;
    }
}
