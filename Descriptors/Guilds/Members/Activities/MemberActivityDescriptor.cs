using Discord.Enums;
using Newtonsoft.Json;

namespace Discord.Descriptors.Guilds.Members.Activities
{
    public class MemberActivityDescriptor : Json.Objects.Guilds.Members.Activities.MemberActivityObject
    {
        public string Name => name;
        public ActivityType ActivityType => type;
        public string Url => url;
        [JsonProperty("timestamps")]
        public MemberActivityTimestampDescriptor Timestamps { get; set; }
        public ulong? ApplicationId => application_id;
        public string Details => details;
        public string State => state;
        [JsonProperty("party")]
        public MemberActivityPartyDescriptor Party { get; set; }
        [JsonProperty("assets")]
        public MemberActivityAssetDescriptor Assets { get; set; }
        [JsonProperty("secrets")]
        public MemberActivitySecretObject Secrets { get; set; }
        public bool? Instance => instance;
        public ActivityFlags? Flags => flags;
    }
}
