using Discord.Enums;
using System;

namespace Discord.Json.Objects.Channels
{
    /// <summary>
    /// Json data sent with a message. https://discordapp.com/developers/docs/resources/channel#message-object
    /// </summary>
    public class MessageObject
    {
        /// <summary>
        /// Message ID
        /// </summary>
        public ulong id;
        /// <summary>
        /// Channel ID
        /// </summary>
        public ulong channel_id;
        /// <summary>
        /// Guild ID
        /// </summary>
        public ulong? guild_id;
        /// <summary>
        /// User object. Only ID relevant
        /// </summary>
        public UserObject author;
        /// <summary>
        /// Member object. Irrelevant with correct mapping
        /// </summary>
        public Guilds.Members.MemberObject member;
        public string content;
        /// <summary>
        /// Actually a datetime. Nothing like consistency
        /// </summary>
        public DateTime? timestamp;
        /// <summary>
        /// Actually a datetime. Nothing like consistency
        /// </summary>
        public DateTime? edited_timestamp;
        public bool tts;
        public bool mention_everyone;
        /// <summary>
        /// User object with an added MemberObject field. MemberObject field irrelevant
        /// </summary>
        public UserObject[] mentions;
        /// <summary>
        /// Role IDs only
        /// </summary>
        public ulong[] mention_roles;
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
