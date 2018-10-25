namespace Discord.Json.Payloads.Received
{
    public class GatewayMemberUpdate
    {
        public ulong guild_id;
        public ulong[] roles;
        public Objects.UserObject user;
        public string nick;
    }
}
