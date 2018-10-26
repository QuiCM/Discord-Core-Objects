namespace Discord.Json.Objects
{
    public class GetGatewayBotResponseObject : GetGatewayResponseObject
    {
        public int shards;
        public SessionStartLimitObject session_start_limit;
    }
}
