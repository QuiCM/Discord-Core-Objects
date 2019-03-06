using Discord.Descriptors.Payloads;
using Newtonsoft.Json;

namespace Discord.Descriptors
{
    /// <summary>
    /// An event that is sent over the gateway. Only for opcode = 0
    /// </summary>
    public class DispatchGatewayEvent<TPayload> : GatewayEvent<TPayload>
    {
        [JsonProperty("s")]
        public int? Sequence { get; set; }
        [JsonProperty("t", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [System.ComponentModel.DefaultValue(null)]
        public Enums.EventType Type { get; set; } = Enums.EventType.NONE;

        public DispatchGatewayEvent() : base() { }
        public DispatchGatewayEvent(GatewayOpCode opCode) : base(opCode) { }
    }
}
