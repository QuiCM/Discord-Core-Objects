using Discord.Descriptors.Guilds;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Discord.Descriptors.Channels
{
    public class VoiceChannelDescriptor : ChannelDescriptor
    {
        [JsonIgnore]
        public virtual GuildDescriptor Guild { get; set; }
        public int VoiceBitRate => bitrate.Value;
        public int VoiceUserLimit => user_limit.Value;
        public int Position { get; set; }
        [JsonProperty("permission_overwrites")]
        public IList<OverwriteDescriptor> PermissionOverwrites { get; set; }
        public ChannelCategoryDescriptor ParentCategory { get; set; }
    }
}
