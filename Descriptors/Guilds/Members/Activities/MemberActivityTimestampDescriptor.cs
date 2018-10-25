using System;
namespace Discord.Descriptors.Guilds.Members.Activities
{
    public class MemberActivityTimestampDescriptor : Json.Objects.Guilds.Members.Activities.MemberActivityTimestampObject
    {
        public DateTime? Start => start;
        public DateTime? End => end;
    }
}
