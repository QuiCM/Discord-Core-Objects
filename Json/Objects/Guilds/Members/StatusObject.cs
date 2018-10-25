using System;

namespace Discord.Json.Objects.Guilds.Members
{
    public class StatusObject
    {
        public DateTime? since;
        public Activities.MemberActivityObject game;
        public string status;
        public bool afk;
    }
}
