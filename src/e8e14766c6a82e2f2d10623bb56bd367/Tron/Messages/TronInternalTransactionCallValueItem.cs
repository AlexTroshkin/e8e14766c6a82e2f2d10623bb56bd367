using Newtonsoft.Json;

namespace e8e14766c6a82e2f2d10623bb56bd367.Tron.Messages
{
    /// <summary>
    /// Call value в internal transaction
    /// </summary>
    public class TronInternalTransactionCallValueItem
    {
        /// <summary>
        /// Значение call value (в TRX или TRC10)
        /// </summary>
        [JsonProperty("callValue")]
        public long CallValue { get; set; }
        
        /// <summary>
        /// TokenId TRC-10 токена (null если это TRX)
        /// </summary>
        [JsonProperty("tokenId")]
        public string? TokenId { get; set; }

        [JsonIgnore]
        public bool IsTrxTransfer => TokenId is null;
    }
}