using System;

namespace Discord.Descriptors.Commands
{
    public class StatusCommand : Json.Commands.GatewayUpdateStatus
    {
        public DateTime? Since { get => since; set => since = value; }
        public Guilds.Members.Activities.MemberActivityDescriptor Game
        {
            get => (Guilds.Members.Activities.MemberActivityDescriptor)game;
            set => game = value;
        }
        public string Status { get => status; set => status = value; }
        public bool Afk { get => afk; set => afk = value; }
    }
}
