using Newtonsoft.Json;

namespace e8e14766c6a82e2f2d10623bb56bd367.Tron.Messages
{
    public class TronChainParameter
    {
        [JsonProperty("key")]
        public string? Name { get; set; }
        
        [JsonProperty("value")]
        public long? Value { get; set; }
    }
}