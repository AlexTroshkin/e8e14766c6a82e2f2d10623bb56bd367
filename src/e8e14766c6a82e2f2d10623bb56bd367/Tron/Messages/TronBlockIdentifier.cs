using Newtonsoft.Json;

namespace e8e14766c6a82e2f2d10623bb56bd367.Tron.Messages
{
    /// <summary>
    /// Идентификатор блока
    /// </summary>
    public class TronBlockIdentifier
    {
        public TronBlockIdentifier(long number, string? hash)
        {
            Number = number;
            Hash = hash;
        }
        
        /// <summary>
        /// Номер блока
        /// </summary>
        [JsonProperty("number")]
        public long Number { get; set; }
        
        /// <summary>
        /// Хэш
        /// </summary>
        [JsonProperty("hash")]
        public string? Hash { get; set; }
    }
}