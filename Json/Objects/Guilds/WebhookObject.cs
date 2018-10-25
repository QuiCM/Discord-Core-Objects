namespace Discord.Json.Objects.Guilds
{
    public class WebhookObject
    {
        public ulong id;
        public ulong? guild_id;
        public ulong channel_id;
        public UserObject user;
        public string name;
        public string avatar;
        public string token;
    }
}
