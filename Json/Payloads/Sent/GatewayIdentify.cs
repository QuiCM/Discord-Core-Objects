namespace Discord.Json.Payloads.Sent
{
    public class GatewayIdentify
    {
        public string token;
        public Objects.ConnectionProperties properties;
        public bool compress;
        public int large_threshold;
        public int[] shard;
        public Objects.Guilds.Members.StatusObject presence;
    }
}
