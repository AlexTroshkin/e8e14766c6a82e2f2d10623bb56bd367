using Newtonsoft.Json;

namespace e8e14766c6a82e2f2d10623bb56bd367.Tron.Messages
{
    /// <summary>
    /// Ключ доступа
    /// </summary>
    public class TronPermissionKeyItem
    {
        /// <summary>
        /// Адрес
        /// </summary>
        [JsonProperty("address")]
        public string? Address { get; set; }
        
        /// <summary>
        /// Вес
        /// </summary>
        [JsonProperty("weight")]
        public long Weight { get; set; }
    }
}