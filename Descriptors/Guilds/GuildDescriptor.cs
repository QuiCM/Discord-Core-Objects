using Discord.Descriptors.Guilds.Members;
using Discord.Enums;
using System;
using System.Collections.Generic;

namespace Discord.Descriptors.Guilds
{
    public class GuildDescriptor : Json.Objects.Guilds.GuildObject
    {
        public ulong Id => id;
        public string Name => name;
        public string IconHash => icon;
        public string SplashImageHash => splash;
        public bool IsOwner => owner;
        public UserDescriptor Owner { get; set; }
        public Permissions Permissions => permissions;
        public string ServerRegion => region;
        public Channels.ChannelDescriptor AfkChannel { get; set; }
        public int AfkTimeout => afk_timeout;
        public bool HasEmbedChannel => embed_enabled;
        public Channels.ChannelDescriptor EmbedChannel { get; set; }
        public VerificationLevel VerificationLevel => verification_level;
        public NotificationLevel NotificationLevel => default_message_notifications;
        public ExplicitContentLevel ExplicitContentLevel => explicit_content_filter;
        public IEnumerable<RoleDescriptor> Roles { get; set; }
        public IEnumerable<EmojiDescriptor> Emojis { get; set; }
        public IEnumerable<string> SpecialFeatures { get; set; }
        public MfaLevel MultiFactorAuthLevel => mfa_level;
        /// <summary>
        /// Present if the guild was created by an OAuth2 application user
        /// </summary>
        public UserDescriptor Application { get; set; }
        public bool HasWidget => widget_enabled;
        public Channels.ChannelDescriptor WidgetChannel { get; set; }
        public bool HasSystemChannel => system_channel_id != null;
        public Channels.ChannelDescriptor SystemChannel { get; set; }
        public DateTime UserJoinedDateTime => joined_at;
        public bool IsLargeServer => large;
        public bool IsUnavailable => unavailable;
        public IEnumerable<MemberDescriptor> Members { get; set; }
        public IEnumerable<Channels.ChannelDescriptor> Channels { get; set; }
        public IEnumerable<PresenceDescriptor> Presences { get; set; }
    }
}
