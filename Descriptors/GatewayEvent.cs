using Discord.Descriptors.Payloads;
using Newtonsoft.Json;

namespace Discord.Descriptors
{
    /// <summary>
    /// An event that is sent over the Gateway
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class GatewayEvent<TPayload>
    {
        /// <summary>
        /// Event's OpCode
        /// </summary>
        [JsonProperty("op")]
        public virtual GatewayOpCode OpCode { get; set; }

        /// <summary>
        /// Data contained in the event. May be null
        /// </summary>
        [JsonProperty("d")]
        public TPayload Payload { get; set; }

        public GatewayEvent(GatewayOpCode opCode)
        {
            OpCode = opCode;
        }
        
        public GatewayEvent() { }

        /// <summary>
        /// Fluently sets the payload value
        /// </summary>
        /// <param name="payload"></param>
        /// <returns></returns>
        public GatewayEvent<TPayload> WithPayload(TPayload payload)
        {
            Payload = payload;
            return this;
        }

        internal virtual GatewayEvent<T> Cast<T>()
        {
            if (typeof(TPayload) == typeof(Newtonsoft.Json.Linq.JToken))
            {
                return new GatewayEvent<T>(OpCode).WithPayload((Payload as Newtonsoft.Json.Linq.JToken).ToObject<T>());
            }
            return null;
        }

        public virtual string Serialize(JsonSerializerSettings jss = null)
        {
            if (jss == null)
            {
                return JsonConvert.SerializeObject(this, Formatting.Indented);
            }

            return JsonConvert.SerializeObject(this, Formatting.Indented, jss);
        }
    }
}
