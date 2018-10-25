namespace Discord.Json.Objects
{
    public class ConnectionObject
    {
        public string id;
        public string name;
        public string type;
        public bool revoked;
        public Guilds.IntegrationObject[] integrations;
    }
}
