using Discord.Enums;

namespace Discord.Json.Objects.Guilds.Members.Activities
{
    public class MemberActivityObject
    {
        public string name;
        public ActivityType type;
        public string url;
        public MemberActivityTimestampObject timestamps;
        public ulong? application_id;
        public string details;
        public string state;
        public MemberActivityPartyObject party;
        public MemberActivityAssetObject assets;
        public bool? instance;
        public ActivityFlags? flags;
    }
}
