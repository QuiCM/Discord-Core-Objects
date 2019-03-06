using System;

namespace Discord.Descriptors.Channels
{
    public class AttachmentDescriptor : Json.Objects.Channels.AttachmentObject
    {
        public ulong Id => id;
        public string FileName => filename;
        public int FileSize => size;
        public string Url => url;
        public string ProxyUrl => proxy_url;
        public int? Height => height;
        public int? Width => width;
    }
}
