namespace Discord.Json.Payloads
{
    public class GatewayEmojisUpdate
    {
        public ulong guild_id;
        public Objects.Guilds.EmojiObject[] emojis;
    }
}
