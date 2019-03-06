using System;

namespace Discord.Json.Objects.Channels.Embeds
{
    public class EmbedObject
    {
        public string title;
        public string type;
        public string description;
        public string url;
        public DateTime timestamp;
        public int color;
        public EmbedFooterObject footer;
        public EmbedImageObject image;
        public EmbedThumbnailObject thumbnail;
        public EmbedVideoObject video;
        public EmbedProviderObject provider;
        public EmbedAuthorObject author;
        public EmbedFieldObject[] fields;
    }
}
