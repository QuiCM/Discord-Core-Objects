namespace Discord.Descriptors.Guilds.Members.Activities
{
    public class MemberActivityAssetDescriptor : Json.Objects.Guilds.Members.Activities.MemberActivityAssetObject
    {
        public string LargeImageHash => large_image;
        public string LargeText => large_text;
        public string SmallImageHash => small_image;
        public string SmallText => small_text;
    }
}
