using System;
using System.Collections.Generic;
using System.Text;

namespace Discord.Descriptors.Guilds.Members
{
    public class StatusDescriptor : Json.Objects.Guilds.Members.StatusObject
    {
        public DateTime? Since => since;
        public Activities.MemberActivityDescriptor Activity => (Activities.MemberActivityDescriptor)game;
        public string Status => status;
        public bool Afk => afk;
    }
}
