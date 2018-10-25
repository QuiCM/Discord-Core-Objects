using System;

namespace Discord.Json.Objects.Guilds
{
    public class IntegrationObject
    {
        public ulong id;
        public string name;
        public string type;
        public bool enabled;
        public bool syncing;
        public ulong role_id;
        public int expire_behavior;
        public int expire_grace_period;
        public UserObject user;
        public IntegrationAccountObject account;
        public DateTime synced_at;
    }
}
