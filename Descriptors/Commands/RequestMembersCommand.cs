namespace Discord.Descriptors.Commands
{
    public class RequestMembersCommand : Json.Commands.GatewayMemberRequest
    {
        private Guilds.GuildDescriptor _guild;
        public Guilds.GuildDescriptor Guild { get => _guild; set { _guild = value; guild_id = value.Id; } }
        public string Query { get => query; set => query = value; }
        public int Limit { get => limit; set => limit = value; }
    }
}
