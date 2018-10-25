using Discord.Descriptors.Guilds;
using System;
using System.Collections.Generic;
using System.Text;

namespace Discord.Descriptors.Channels
{
    public class VoiceChannelDescriptor : ChannelDescriptor
    {
        public GuildDescriptor Guild { get; set; }
        public int VoiceBitRate => bitrate.Value;
        public int VoiceUserLimit => user_limit.Value;
        public int Position { get; set; }
        public IEnumerable<OverwriteDescriptor> PermissionOverwrites => (IEnumerable<OverwriteDescriptor>)permission_overwrites;
        public ChannelCategoryDescriptor ParentCategory { get; set; }
    }
}
