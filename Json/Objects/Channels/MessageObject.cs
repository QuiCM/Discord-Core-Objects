using Discord.Enums;
using System;

namespace Discord.Json.Objects.Channels
{
    /// <summary>
    /// Json data sent with a message. https://discordapp.com/developers/docs/resources/channel#message-object
    /// </summary>
    public class MessageObject
    {
        public ulong id;
        public ulong channel_id;
        public ulong author;
        public Guilds.Members.MemberObject member;
        public string content;
        public DateTime? timestamp;
        public DateTime? edited_timestamp;
        public bool tts;
        public bool mention_everyone;
        public UserObject[] mentions;
        public Guilds.RoleObject[] mention_roles;
        public AttachmentObject[] attachments;
        public Embeds.EmbedObject[] embeds;
        public ReactionObject[] reactions;
        public ulong? nonce;
        public bool pinned;
        public ulong webhook_id;
        public MessageType type;
        public MessageActivityObject activity;
        public MessageApplicationObject application;
    }
}
