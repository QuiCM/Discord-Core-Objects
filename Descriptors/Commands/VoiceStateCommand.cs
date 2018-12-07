namespace Discord.Descriptors.Commands
{
    public class VoiceStateCommand : Json.Commands.GatewayUpdateVoiceState
    {
        private Guilds.GuildDescriptor _guild;
        private Channels.ChannelDescriptor _channel;

        public Guilds.GuildDescriptor Guild { get => _guild; set { _guild = value; guild_id = value.Id; } }
        public Channels.ChannelDescriptor Channel { get => _channel; set { _channel = value; channel_id = value.Id; } }
        public bool SelfMute { get => self_mute; set => self_mute = value; }
        public bool SelfDeafen { get => self_deafen; set => self_deafen = value; }
    }
}
