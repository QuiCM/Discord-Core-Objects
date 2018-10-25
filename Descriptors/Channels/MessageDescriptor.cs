using Discord.Descriptors.Guilds;
using Discord.Descriptors.Guilds.Members;
using Discord.Enums;
using System;
using System.Collections.Generic;

namespace Discord.Descriptors.Channels
{
    public class MessageDescriptor : Json.Objects.Channels.MessageObject
    {
        public ulong Id => id;
        public ChannelDescriptor Channel { get; set; }
        public MemberDescriptor Sender { get; set; }
        public string Content => content;
        public DateTime? SentAt => timestamp;
        public DateTime? EditedAt => edited_timestamp;
        public bool IsTts => tts;
        public bool MentionsEveryone => mention_everyone;
        public IEnumerable<MemberDescriptor> MentionedUsers { get; set; }
        public IEnumerable<RoleDescriptor> MentionedRoles { get; set; }
        public IEnumerable<AttachmentDescriptor> AttachedItems { get; set; }
        public IEnumerable<ReactionDescriptor> AttachedReactions { get; set; }
        public ulong? Nonce => nonce;
        public bool IsPinned => pinned;
        public WebhookDescriptor Webhook { get; set; }
        public MessageType Type => type;
    }
}
