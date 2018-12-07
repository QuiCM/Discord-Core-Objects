namespace Discord.Descriptors.Payloads
{
    public class ReadyEvent
    {
        public int v;
        //public Objects.UserObject user;
        //public Objects.Channels.ChannelObject[] private_channels;
        //public Objects.Guilds.GuildObject[] guilds;
        public string session_id;
        public string[] _trace;
    }
}
