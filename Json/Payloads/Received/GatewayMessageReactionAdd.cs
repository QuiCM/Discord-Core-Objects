namespace Discord.Json.Payloads
{
    /// <summary>
    /// Brief Json data attached to a message object
    /// </summary>
    public class GatewayMessageReactionAdd
    {
        public ulong user_id;
        public ulong channel_id;
        public ulong message_id;
        public Objects.Guilds.EmojiObject emoji;
    }
}
