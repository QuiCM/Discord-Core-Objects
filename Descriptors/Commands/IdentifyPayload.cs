using Discord.Json.Commands;
using Newtonsoft.Json;
using System;

namespace Discord.Descriptors.Commands
{
    public class IdentifyPayload : GatewayIdentify
    {
        [JsonProperty("token")]
        public string Token { get => token; set => token = value; }

        [JsonProperty("properties")]
        public Json.Objects.ConnectionProperties Properties { get => properties; set => properties = value; }

        [JsonProperty("compress", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Compress { get => compress; set => compress = value; }

        [JsonProperty("large_threshold", NullValueHandling = NullValueHandling.Ignore)]
        public int? LargeThreshold
        {
            get => large_threshold;
            set
            {
                large_threshold = value != null
                    ? value < 50 ? 50 : value > 250 ? 250 : value
                    : null;
            }
        }

        [JsonProperty("shard", NullValueHandling = NullValueHandling.Ignore)]
        public int[] Shards
        {
            get => shard;
            set
            {
                if (value != null)
                {
                    if (value.Length != 2)
                    {
                        throw new ArgumentException("Shard value must be an array of 2 numbers: [ shard_id, num_shards ]", "value");
                    }
                }

                shard = value;
            }
        }

        [JsonProperty("presence", NullValueHandling = NullValueHandling.Ignore)]
        public Guilds.Members.StatusDescriptor Presence
        {
            get => (Guilds.Members.StatusDescriptor)presence;
            set => presence = value;
        }
    }
}
