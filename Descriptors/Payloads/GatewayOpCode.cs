namespace Discord.Descriptors.Payloads
{
    public enum GatewayOpCode
    {
        /// <summary>
        /// Receive
        /// </summary>
        Dispatch = 0,
        /// <summary>
        /// Send/Receive
        /// </summary>
        Heartbeat = 1,
        /// <summary>
        /// Send
        /// </summary>
        Identify = 2,
        /// <summary>
        /// Send
        /// </summary>
        StatusUpdate = 3,
        /// <summary>
        /// Send
        /// </summary>
        VoiceStateUpdate = 4,
        /// <summary>
        /// Send
        /// </summary>
        Resume = 6,
        /// <summary>
        /// Receive
        /// </summary>
        Reconnect = 7,
        /// <summary>
        /// Send
        /// </summary>
        RequestGuildMembers = 8,
        /// <summary>
        /// Receive
        /// </summary>
        InvalidSession = 9,
        /// <summary>
        /// Receive
        /// </summary>
        Hello = 10,
        /// <summary>
        /// Receive
        /// </summary>
        HeartbeatAck = 11,
        /// <summary>
        /// Used for sending events to handlers. Registering a handler against <see cref="GatewayOpCode.All"/>
        /// will cause every event to be sent through the handler.
        /// </summary>
        All = 255
    }
}
