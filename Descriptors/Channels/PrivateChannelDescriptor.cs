using System;
using System.Collections.Generic;
using System.Text;

namespace Discord.Descriptors.Channels
{
    public class PrivateChannelDescriptor : ChannelDescriptor
    {
        public IEnumerable<UserDescriptor> Recipients { get; set; }
        public string IconHash => icon;
        public UserDescriptor Owner { get; set; }
        public MessageDescriptor LastMessage { get; set; }
    }
}
