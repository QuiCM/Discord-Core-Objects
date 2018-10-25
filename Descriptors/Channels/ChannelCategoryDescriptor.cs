using Discord.Descriptors.Guilds;
using System.Collections.Generic;

namespace Discord.Descriptors.Channels
{
    public class ChannelCategoryDescriptor : ChannelDescriptor
    {
        public int Position => position.Value;
        public bool IsNsfw => nsfw.Value;
        public IEnumerable<OverwriteDescriptor> PermissionOverwrites => (IEnumerable<OverwriteDescriptor>)permission_overwrites;
        public GuildDescriptor Guild { get; set; }
    }
}
