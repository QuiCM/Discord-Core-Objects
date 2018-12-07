namespace Discord.Descriptors.Commands
{
    public class ResumeCommand : Json.Commands.GatewayResume
    {
        public string Token { get => token; set => token = value; }
        public string Session { get => session_id; set => session_id = value; }
        public int Sequence { get => seq; set => seq = value; }
    }
}
