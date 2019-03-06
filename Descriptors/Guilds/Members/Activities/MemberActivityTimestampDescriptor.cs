using System;
namespace Discord.Descriptors.Guilds.Members.Activities
{
    public class MemberActivityTimestampDescriptor : Json.Objects.Guilds.Members.Activities.MemberActivityTimestampObject
    {
        public DateTime? Start => start.HasValue 
            ? (DateTime?)DateTimeOffset.FromUnixTimeMilliseconds(start.Value).DateTime 
            : null;
        public DateTime? End => end.HasValue 
            ? (DateTime?)DateTimeOffset.FromUnixTimeMilliseconds(end.Value).DateTime
            : null;
    }
}
