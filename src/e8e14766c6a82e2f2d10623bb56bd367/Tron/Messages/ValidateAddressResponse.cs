using Newtonsoft.Json;

namespace e8e14766c6a82e2f2d10623bb56bd367.Tron.Messages
{
    /// <summary>
    /// Ответ на запрос валидации адреса
    /// </summary>
    public class ValidateAddressResponse : TronResponseBase
    {
        /// <summary>
        /// Валиден ли адрес
        /// </summary>
        [JsonProperty("result")]
        public bool IsValid { get; set; }

        [JsonIgnore]
        public bool IsBase58Address => Message == "Base58check format";
        
        [JsonIgnore]
        public bool IsHexAddress => Message == "Hex string format";
        
        /// <summary>
        /// Формат переданного адреса
        /// Для hex: Hex string format
        /// Для base58: Base58check format
        /// </summary>
        [JsonProperty("message")]
        public string? Message { get; set; }
    }
}