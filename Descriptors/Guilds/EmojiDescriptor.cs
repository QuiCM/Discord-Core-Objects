using Discord.Descriptors.Guilds.Members;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Discord.Descriptors.Guilds
{
    public class EmojiDescriptor : Json.Objects.Guilds.EmojiObject
    {
        public ulong? Id => id;
        public string Name => name;
        [JsonProperty("roles")]
        public IList<RoleDescriptor> Roles { get; set; }
        public UserDescriptor Creator { get; set; }
        public bool RequiresColons => require_colons;
        public bool IsIntegrationManaged => managed;
        public bool IsAnimated => animated;
    }
}
