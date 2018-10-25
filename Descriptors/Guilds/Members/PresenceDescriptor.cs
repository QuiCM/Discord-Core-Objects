using System;
using System.Collections.Generic;
using System.Text;

namespace Discord.Descriptors.Guilds.Members
{
    public class PresenceDescriptor : Json.Objects.Guilds.Members.PresenceObject
    {
        public UserDescriptor User { get; set; }
        public IEnumerable<RoleDescriptor> Roles { get; set; }
        public Activities.MemberActivityDescriptor Game => (Activities.MemberActivityDescriptor)game;
        public GuildDescriptor Guild { get; set; }
        public string Status => status;
    }
}
