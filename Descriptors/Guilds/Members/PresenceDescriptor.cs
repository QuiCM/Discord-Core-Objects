using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Discord.Descriptors.Guilds.Members
{
    public class PresenceDescriptor : Json.Objects.Guilds.Members.PresenceObject
    {
        public UserDescriptor User { get; set; }
        [JsonIgnore] //Roles sent as IDs
        public IList<RoleDescriptor> Roles { get; set; }
        [JsonProperty("game")]
        public Activities.MemberActivityDescriptor Game { get; set; }
        [JsonIgnore]
        public virtual GuildDescriptor Guild { get; set; }
        public string Status => status;
        [JsonProperty("activities")]
        public Activities.MemberActivityDescriptor[] Activities { get; set; }
    }
}
