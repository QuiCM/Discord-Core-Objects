namespace Discord.Enums
{
    /// <summary>
    /// Types of valid activities that can be sent with presence updates
    /// </summary>
    public enum ActivityType : int
    {
        /// <summary>
        /// User is playing a game. Presence set to 'Playing {name}'
        /// </summary>
        Game = 0,
        /// <summary>
        /// User is streaming. Presence set to 'Streaming {name}'
        /// </summary>
        Streaming = 1,
        /// <summary>
        /// User is listening to something. Presence set to 'Listening to {name}'
        /// </summary>
        Listening = 2
    }
}
