using Discord.Descriptors.Guilds.Members;
using Discord.Enums;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Discord.Descriptors.Guilds
{
    public class GuildDescriptor : Json.Objects.Guilds.GuildObject
    {
        public virtual ulong Id => id;
        public virtual string Name => name;
        public virtual string IconHash => icon;
        public virtual string SplashImageHash => splash;
        public virtual bool IsOwner => owner;
        [JsonIgnore] //Json result provides ID - need to retrieve full object
        public virtual UserDescriptor Owner { get; set; }
        public virtual Permissions Permissions => permissions;
        public virtual string ServerRegion => region;
        [JsonIgnore] //JSON result provides ID - need to retrieve full object
        public virtual Channels.ChannelDescriptor AfkChannel { get; set; }
        public virtual int AfkTimeout => afk_timeout;
        public virtual bool HasEmbedChannel => embed_enabled;
        [JsonIgnore] //Json result provides ID - need to retrieve full object
        public virtual Channels.ChannelDescriptor EmbedChannel { get; set; }
        public virtual VerificationLevel VerificationLevel => verification_level;
        public virtual NotificationLevel NotificationLevel => default_message_notifications;
        public virtual ExplicitContentLevel ExplicitContentLevel => explicit_content_filter;
        public virtual IEnumerable<string> SpecialFeatures { get; set; }
        public virtual MfaLevel MultiFactorAuthLevel => mfa_level;
        /// <summary>
        /// Present if the guild was created by an OAuth2 application user
        /// </summary>
        [JsonIgnore] //Json result provides ID - need to retrieve full object
        public virtual UserDescriptor Application { get; set; }
        public virtual bool HasWidget => widget_enabled;
        [JsonIgnore] //Json result provides ID - need to retrieve full object
        public virtual Channels.ChannelDescriptor WidgetChannel { get; set; }
        public virtual bool HasSystemChannel => system_channel_id != null;
        [JsonIgnore] //Json result provides ID - need to retrieve full object
        public virtual Channels.ChannelDescriptor SystemChannel { get; set; }
        public virtual DateTime UserJoinedDateTime => joined_at;
        public virtual bool IsLargeServer => large;
        public virtual bool IsUnavailable => unavailable;
        [JsonProperty("members")]
        public virtual IList<MemberDescriptor> Members { get; set; }
        [JsonProperty("channels")]
        public virtual IList<Channels.ChannelDescriptor> Channels { get; set; }
        [JsonProperty("presences")]
        public virtual IList<PresenceDescriptor> Presences { get; set; }
        [JsonProperty("roles")]
        public virtual IList<RoleDescriptor> Roles { get; set; }
        [JsonProperty("emojis")]
        public virtual IList<EmojiDescriptor> Emojis { get; set; }
        [JsonProperty("voice_states")]
        public virtual IList<VoiceStateDescriptor> VoiceStates { get; set; }
    }
}
