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
        [JsonProperty("t")]
        public string Name { get; set; }

        public DispatchGatewayEvent() : base() { }
        public DispatchGatewayEvent(GatewayOpCode opCode) : base(opCode) { }

        internal override GatewayEvent<T> Cast<T>()
        {
            if (typeof(TPayload) == typeof(Newtonsoft.Json.Linq.JToken))
            {
                return new DispatchGatewayEvent<T>(OpCode)
                {
                    Name = Name,
                    Sequence = Sequence
                }.WithPayload((Payload as Newtonsoft.Json.Linq.JToken).ToObject<T>());
            }
            return null;
        }
    }
}
