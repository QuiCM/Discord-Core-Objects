namespace Discord.Enums
{
    /// <summary>
    /// Guild multi-factor authentication level
    /// </summary>
    public enum MfaLevel : int
    {
        /// <summary>
        /// No MFA is required
        /// </summary>
        NONE = 0,
        /// <summary>
        /// Elevated user actions will require MFA
        /// </summary>
        ELEVATED = 1
    }
}
