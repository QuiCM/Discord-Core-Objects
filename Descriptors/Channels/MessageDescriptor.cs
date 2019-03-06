using Discord.Descriptors.Guilds;
using Discord.Descriptors.Guilds.Members;
using Discord.Enums;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Discord.Descriptors.Channels
{
    public class MessageDescriptor : Json.Objects.Channels.MessageObject
    {
        public ulong Id => id;
        /// <summary>
        /// Not present for private messages
        /// </summary>
        public GuildDescriptor Guild { get; set; }
        public ChannelDescriptor Channel { get; set; }
        public MemberDescriptor Sender { get; set; }
        public string Content => content;
        public DateTime? SentAt => timestamp;
        public DateTime? EditedAt => edited_timestamp;
        public bool IsTts => tts;
        public bool MentionsEveryone => mention_everyone;
        [JsonIgnore]
        public IList<MemberDescriptor> MentionedUsers { get; set; }
        [JsonIgnore]
        public IList<RoleDescriptor> MentionedRoles { get; set; }
        [JsonProperty("attachments")]
        public IList<AttachmentDescriptor> Attachments { get; set; }
        [JsonProperty("reactions")]
        public IList<ReactionDescriptor> Reactions { get; set; }
        public ulong? Nonce => nonce;
        public bool IsPinned => pinned;
        public WebhookDescriptor Webhook { get; set; }
        public MessageType Type => type;
    }
}
