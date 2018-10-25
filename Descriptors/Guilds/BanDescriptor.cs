namespace Discord.Descriptors.Guilds
{
    public class BanDescriptor : Json.Objects.Guilds.BanObject
    {
        public UserDescriptor User { get; set; }
        public string Reason => reason;
    }
}
