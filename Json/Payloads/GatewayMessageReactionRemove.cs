namespace Discord.Json.Payloads
{
    public class GatewayMessageReactionRemove
    {
        public ulong user_id;
        public ulong channel_id;
        public ulong message_id;
        public Objects.Guilds.EmojiObject emoji;
    }
}
