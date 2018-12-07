using System;

namespace Discord.Json.Commands
{
    public class GatewayUpdateStatus
    {
        public DateTime? since;
        public Objects.Guilds.Members.Activities.MemberActivityObject game;
        public string status;
        public bool afk;
    }
}
