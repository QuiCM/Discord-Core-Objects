using Discord.Enums;
using System;

namespace Discord.Json.Objects.Guilds
{
    /// <summary>
    /// Json data for a Guild (aka Server) object
    /// </summary>
    public class GuildObject
    {
        public ulong id;
        public string name;
        public string icon;
        public string splash;
        public bool owner;
        public ulong owner_id;
        public Permissions permissions;
        public string region;
        public ulong afk_channel_id;
        public int afk_timeout;
        public bool embed_enabled;
        public ulong embed_channel_id;
        public VerificationLevel verification_level;
        public NotificationLevel default_message_notifications;
        public ExplicitContentLevel explicit_content_filter;
        public RoleObject[] roles;
        public EmojiObject[] emojis;
        public string[] features;
        public MfaLevel mfa_level;
        public ulong? application_id;
        public bool widget_enabled;
        public ulong widget_channel_id;
        public ulong? system_channel_id;
        public DateTime joined_at;
        public bool large;
        public bool unavailable;
        public int member_count;
        public Members.VoiceStateObject[] voice_states;
        public Members.MemberObject[] members;
        public Channels.ChannelObject[] channels;
        public Members.PresenceObject[] presences;
	}
}
