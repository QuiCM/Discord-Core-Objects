namespace Discord.Json.Payloads.Received
{
    public class GatewayReady
    {
        public int v;
        public Objects.UserObject user;
        public Objects.Channels.ChannelObject[] private_channels;
        public Objects.Guilds.GuildObject[] guilds;
        public string session_id;
        public string[] _trace;
    }
}
