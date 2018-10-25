namespace Discord.Json.Payloads.Received
{
    public class GatewayEmojisUpdate
    {
        public ulong guild_id;
        public Objects.Guilds.EmojiObject[] emojis;
    }
}
