namespace Discord.Json.Payloads.Received
{
    /// <summary>
    /// Used in MessageDeleteBulk events
    /// </summary>
    public class GatewayBulkMessageDelete
    {
        /// <summary>
        /// Channel in which messages are being deleted
        /// </summary>
        public ulong channel_id;
        /// <summary>
        /// IDs of deleted messages
        /// </summary>
        public ulong[] ids;
    }
}
