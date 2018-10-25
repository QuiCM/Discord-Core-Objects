namespace Discord.Descriptors
{
    public class UserDescriptor : Json.Objects.UserObject
    {
        public ulong Id => id;
        public string Username => username;
        public string Discriminator => discriminator;
        public string AvatarHash => avatar;
        public bool? IsBot => bot;
        public bool? IsMultiFactorAuthEnabled => mfa_enabled;
        public bool? IsVerified => verified;
        public string Email => email;
    }
}
