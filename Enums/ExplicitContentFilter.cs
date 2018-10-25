namespace Discord.Enums
{
    /// <summary>
    /// Guild explicit content filter level
    /// </summary>
    public enum ExplicitContentLevel : int
    {
        /// <summary>
        /// No explicit content filtering will take place
        /// </summary>
        DISABLED = 0,
        /// <summary>
        /// Members without roles will have their content filtered
        /// </summary>
        MEMBERS_WITHOUT_ROLES = 1,
        /// <summary>
        /// All members will have their content filtered
        /// </summary>
        ALL_MEMBERS = 2
    }
}
