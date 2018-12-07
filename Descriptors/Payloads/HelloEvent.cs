namespace Discord.Descriptors.Payloads
{
    public class HelloPayload : Json.Payloads.GatewayHello
    {
        public int HeartbeatInterval => heartbeat_interval;
        public string[] Trace => _trace;
    }
}
