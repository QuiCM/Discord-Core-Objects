namespace Discord.Descriptors.Channels
{
    public class MessageActivityDescriptor : Json.Objects.Channels.MessageActivityObject
    {
        public Enums.ActivityType ActivityType => type;
        public string PartyId => party_id;
    }
}
