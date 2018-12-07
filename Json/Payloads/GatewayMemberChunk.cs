namespace Discord.Json.Payloads
{
    /// <summary>
    /// Received in response to a Gateway Member Chunk request
    /// </summary>
    public class GatewayMemberChunk
    {
        /// <summary>
        /// The Guild to which the Member Chunk is aimed at
        /// </summary>
        public ulong guild_id;
        /// <summary>
        /// Members returned by the Member Chunk
        /// </summary>
        public Objects.Guilds.Members.MemberObject[] members;
    }
}
