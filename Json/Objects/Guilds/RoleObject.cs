using Discord.Enums;

namespace Discord.Json.Objects.Guilds
{
    /// <summary>
    /// Contains data involved in role management
    /// </summary>
    public class RoleObject
    {
        public ulong id;
        public string name;
        public int color;
        public bool hoist;
        public int position;
        public Permissions permissions;
        public bool managed;
        public bool mentionable;
    }
}
