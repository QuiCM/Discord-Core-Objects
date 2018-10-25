using System;

namespace Discord.Json.Payloads.Received
{
    public class GatewayChannelPinsUpdate
    {
        public ulong channel_id;
        public DateTime? last_pin_timestamp;
    }
}
