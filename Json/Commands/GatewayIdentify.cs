using System.Runtime.Serialization;

namespace Discord.Json.Commands
{
    public class GatewayIdentify
    {
        protected string token;
        protected Objects.ConnectionProperties properties;
        protected bool? compress;
        protected int? large_threshold;
        protected int[] shard;
        protected Objects.Guilds.Members.StatusObject presence;
    }
}
