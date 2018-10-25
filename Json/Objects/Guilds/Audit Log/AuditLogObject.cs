using Discord.Enums;
using System;
using System.Collections.Generic;

namespace Discord.Json.Objects.Guilds.Audit_Log
{
    public class AuditLogObject
    {
        public WebhookObject[] webhooks;
        public UserObject[] users;
        public AuditLogEntryObject[] audit_log_entries;

        public Dictionary<string, Type> AuditLogChangeKeyMap = new Dictionary<string, Type>
        {
            ["name"]                            = typeof(string),
            ["icon_hash"]                       = typeof(string),
            ["splash_hash"]                     = typeof(string),
            ["owner_id"]                        = typeof(ulong),
            ["region"]                          = typeof(string),
            ["afk_channel_id"]                  = typeof(ulong),
            ["afk_timeout"]                     = typeof(int),
            ["mfa_level"]                       = typeof(int),
            ["verification_level"]              = typeof(int),
            ["explicit_content_filter"]         = typeof(int),
            ["default_message_notifications"]   = typeof(int),
            ["vanity_url_code"]                 = typeof(string),
            ["$add"]                            = typeof(RoleObject[]),
            ["$remove"]                         = typeof(RoleObject[]),
            ["prune_delete_days"]               = typeof(int),
            ["widget_enabled"]                  = typeof(bool),
            ["widget_channel_id"]               = typeof(ulong),
            ["position"]                        = typeof(int),
            ["topic"]                           = typeof(string),
            ["bitrate"]                         = typeof(int),
            ["permission_overwrites"]           = typeof(OverwriteObject[]),
            ["nsfw"]                            = typeof(bool),
            ["application_id"]                  = typeof(ulong),
            ["permissions"]                     = typeof(Permissions),
            ["color"]                           = typeof(int),
            ["hoist"]                           = typeof(bool),
            ["mentionable"]                     = typeof(bool),
            ["allow"]                           = typeof(Permissions),
            ["deny"]                            = typeof(Permissions),
            ["code"]                            = typeof(string),
            ["channel_id"]                      = typeof(ulong),
            ["inviter_id"]                      = typeof(ulong),
            ["max_uses"]                        = typeof(int),
            ["uses"]                            = typeof(int),
            ["max_age"]                         = typeof(int),
            ["temporary"]                       = typeof(bool),
            ["deaf"]                            = typeof(bool),
            ["mute"]                            = typeof(bool),
            ["nick"]                            = typeof(string),
            ["avatar_hash"]                     = typeof(string),
            ["id"]                              = typeof(ulong),
            ["type"]                            = typeof(string)
        };
    }
}
