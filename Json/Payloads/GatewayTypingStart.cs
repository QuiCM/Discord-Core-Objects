using System;

namespace Discord.Json.Payloads
{
    public class GatewayTypingStart
    {
        public ulong channel_id;
        public ulong user_id;
        public DateTime timestamp;
    }
}
