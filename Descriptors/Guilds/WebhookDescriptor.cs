using Discord.Descriptors.Channels;

namespace Discord.Descriptors.Guilds
{
    public class WebhookDescriptor : Json.Objects.Guilds.WebhookObject
    {
        public ulong Id => id;
        public GuildDescriptor Guild { get; set; }
        public ChannelDescriptor Channel { get; set; }
        public UserDescriptor User { get; set; }
        public string Name => name;
        public string AvatarHash => avatar;
        public string Token => token;
    }
}
