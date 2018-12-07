using System;
using System.Collections.Generic;
using System.Text;

namespace Discord.Descriptors
{
    public class ConnectionDescriptor : Json.Objects.ConnectionObject
    {
        public string Id => id;
        public string Name => name;
        public string Type => type;
        public bool Revoked => revoked;
        //public IntegrationDescriptor[] Integrations;
    }
}
