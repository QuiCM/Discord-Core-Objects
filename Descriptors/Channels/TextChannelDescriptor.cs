using Discord.Descriptors.Guilds;
using System.Collections.Generic;

namespace Discord.Descriptors.Channels
{
    public class TextChannelDescriptor : ChannelDescriptor
    {
        public GuildDescriptor Guild { get; set; }
        public string Topic => topic;
        public bool IsNsfw => nsfw.Value;
        public int Position => position.Value;
        public IEnumerable<OverwriteDescriptor> PermissionOverwrites => (IEnumerable<OverwriteDescriptor>)permission_overwrites;
        public ChannelCategoryDescriptor ParentCategory { get; set; }
        public MessageDescriptor LastMessage { get; set; }
    }
}
