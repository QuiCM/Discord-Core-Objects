using Discord.Descriptors.Guilds;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Discord.Descriptors.Channels
{
    public class TextChannelDescriptor : ChannelDescriptor
    {
        [JsonIgnore]
        public virtual GuildDescriptor Guild { get; set; }
        public string Topic => topic;
        public bool IsNsfw => nsfw.Value;
        public int Position => position.Value;
        [JsonProperty("permission_overwrites")]
        public IList<OverwriteDescriptor> PermissionOverwrites { get; set; }
        public ChannelCategoryDescriptor ParentCategory { get; set; }
        public MessageDescriptor LastMessage { get; set; }
    }
}
