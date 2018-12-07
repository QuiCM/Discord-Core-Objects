namespace Discord.Json.Payloads
{
    public class GatewayMemberUpdate
    {
        public ulong guild_id;
        public ulong[] roles;
        public Objects.UserObject user;
        public string nick;
    }
}
