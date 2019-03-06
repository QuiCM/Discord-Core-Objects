using Discord.Descriptors.Guilds;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Discord.Descriptors.Channels
{
    public class ChannelCategoryDescriptor : ChannelDescriptor
    {
        public int Position => position.Value;
        public bool IsNsfw => nsfw.Value;
        [JsonProperty("permission_overwrites")]
        public IList<OverwriteDescriptor> PermissionOverwrites { get; set; }
        public GuildDescriptor Guild { get; set; }
    }
}
