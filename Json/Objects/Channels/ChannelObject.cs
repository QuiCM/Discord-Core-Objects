using System;

namespace Discord.Json.Objects.Channels
{
    public class ChannelObject
    {
        public ulong id;
        public Enums.ChannelType type;
        public ulong? guild_id;
        public int? position;
        public Guilds.OverwriteObject[] permission_overwrites;
        public string name;
        public string topic;
        public bool? nsfw;
        public ulong? last_message_id;
        public int? bitrate;
        public int? user_limit;
        public UserObject[] recipients;
        public string icon;
        public ulong? owner_id;
        public ulong? application_id;
        public ulong? parent_id;
        public DateTime? last_pin_timestamp;
    }
}
