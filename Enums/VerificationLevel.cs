namespace Discord.Enums
{
    /// <summary>
    /// Guild verification level
    /// </summary>
    public enum VerificationLevel : int
    {
        /// <summary>
        /// No verification required
        /// </summary>
        NONE = 0,
        /// <summary>
        /// Users must have verified email accounts
        /// </summary>
        LOW = 1,
        /// <summary>
        /// Users must be registered on Discord for more than 5 minutes
        /// </summary>
        MEDIUM = 2,
        /// <summary>
        /// Users must be a member of the server for more than 10 minutes
        /// </summary>
        HIGH = 3,
        /// <summary>
        /// Users must have a verified phone number
        /// </summary>
        VERY_HIGH = 4
    }
}
