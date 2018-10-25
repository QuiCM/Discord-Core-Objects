namespace Discord.Enums
{
    /// <summary>
    /// Valid status types sent with a presence update
    /// </summary>
    public class StatusType
    {
        /// <summary>
        /// The user is idle (orange marker)
        /// </summary>
        public const string IDLE = "idle";
        /// <summary>
        /// The user is in Do Not Disturb mode (red marker)
        /// </summary>
        public const string DND = "dnd";
        /// <summary>
        /// The user is online (green marker)
        /// </summary>
        public const string ONLINE = "online";
        /// <summary>
        /// The user is offline (grey marker)
        /// </summary>
        public const string OFFLINE = "offline";
        /// <summary>
        /// The user is invisible and shown as offline (grey marker)
        /// </summary>
        public const string INVISIBLE = "invisible";
    }
}
