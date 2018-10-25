using System;

namespace Discord.Json.Objects.Guilds
{
    public class InviteMetadataObject
    {
        public UserObject inviter;
        public int uses;
        public int max_uses;
        public int max_age;
        public bool temporary;
        public DateTime created_at;
        public bool revoked;
    }
}
