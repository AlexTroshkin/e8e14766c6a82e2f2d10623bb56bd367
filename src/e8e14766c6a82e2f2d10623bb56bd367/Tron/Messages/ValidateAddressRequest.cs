using Newtonsoft.Json;

namespace e8e14766c6a82e2f2d10623bb56bd367.Tron.Messages
{
    /// <summary>
    /// Запрос на валидацию адреса
    /// </summary>
    public class ValidateAddressRequest : ITronRequest
    {
        /// <summary>
        /// Адрес в base58 или hex
        /// </summary>
        [JsonProperty("address")]
        public string? Address { get; set; }
    }
}