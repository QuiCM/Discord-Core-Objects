using Discord.Descriptors.Guilds;
using Discord.Descriptors.Guilds.Members;

namespace Discord.Descriptors.Channels
{
    public class ReactionDescriptor : Json.Objects.Channels.ReactionObject
    {
        public MemberDescriptor Member { get; set; }
        public MessageDescriptor Message { get; set; }
        public ChannelDescriptor Channel { get; set; }
        public EmojiDescriptor Reaction { get; set; }
    }
}