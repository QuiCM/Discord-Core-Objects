using Discord.Enums;

namespace Discord.Descriptors.Guilds.Members.Activities
{
    public class MemberActivityDescriptor : Json.Objects.Guilds.Members.Activities.MemberActivityObject
    {
        public string Name => name;
        public ActivityType ActivityType => type;
        public System.Uri Uri => new System.Uri(url);
        public MemberActivityTimestampDescriptor Timestamps => (MemberActivityTimestampDescriptor)timestamps;
        public ulong? ApplicationId => application_id;
        public string Details => details;
        public string State => state;
        public MemberActivityPartyDescriptor Party => (MemberActivityPartyDescriptor)party;
        public MemberActivityAssetDescriptor Assets => (MemberActivityAssetDescriptor)assets;
    }
}
