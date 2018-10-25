using System;
using System.Collections.Generic;
using System.Text;

namespace Discord.Descriptors.Channels
{
    public class MessageApplicationDescriptor : Json.Objects.Channels.MessageApplicationObject
    {
        public ulong Id => id;
        public string CoverImageHash => cover_image;
        public string Description => description;
        public string IconHash => icon;
        public string Name => name;
    }
}
