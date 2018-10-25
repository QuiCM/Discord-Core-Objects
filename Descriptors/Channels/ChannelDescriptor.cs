namespace Discord.Descriptors.Channels
{
    public abstract class ChannelDescriptor : Json.Objects.Channels.ChannelObject
    {
        public string Name => name;
        public ulong Id => id;
        public Enums.ChannelType ChannelType => type;
    }
}
