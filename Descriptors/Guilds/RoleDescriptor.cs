using Discord.Enums;

namespace Discord.Descriptors.Guilds
{
    public class RoleDescriptor : Json.Objects.Guilds.RoleObject
    {
        public ulong Id => id;
        public string Name => name;
        public int Color => color;
        public bool IsHoisted => hoist;
        public int Position => position;
        public Permissions Permissions => permissions;
        public bool Managed => managed;
        public bool IsMentionable => mentionable;
    }
}
