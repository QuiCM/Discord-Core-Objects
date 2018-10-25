namespace Discord.Json.Objects.Guilds.Audit_Log
{
    public class AuditLogEntryObject
    {
        public string target_id;
        public AuditLogChangeObject[] changes;
        public long user_id;
        public long id;
        public Enums.AuditLogEvent action_type;
        public AuditLogEntryInfoObject options;
        public string reason;
    }
}
