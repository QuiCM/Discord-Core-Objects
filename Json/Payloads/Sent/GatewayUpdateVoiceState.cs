﻿namespace Discord.Json.Payloads.Sent
{
    public class GatewayUpdateVoiceState
    {
        public ulong guild_id;
        public ulong? channel_id;
        public bool self_mute;
        public bool self_deafen;
    }
}
