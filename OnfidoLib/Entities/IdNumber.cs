using Newtonsoft.Json;

namespace OnfidoLib.Entities
{
    public class IdNumber
    {
        [JsonProperty("type")]
        public string Type;

        [JsonProperty("value")]
        public string Value;

        [JsonProperty("state")]
        public string State;
    }
}
