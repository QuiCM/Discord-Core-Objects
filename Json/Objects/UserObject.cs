using Discord.Enums;

namespace Discord.Json.Objects
{
    public class UserObject
    {
        public ulong id;
        public string username;
        public string discriminator;
        public string avatar;
        public bool? bot;
        public bool? mfa_enabled;
        public bool? verified;
        public string email;
        public UserFlags flags;
        public NitroSubscription premium_type;
    }
}
