namespace Discord.Descriptors.Guilds
{
    public class OverwriteDescriptor : Json.Objects.Guilds.OverwriteObject
    {
        public ulong Id => id;
        public string Type => type;
        public Enums.Permissions Allow => allow;
        public Enums.Permissions Deny => deny;
    }
}
