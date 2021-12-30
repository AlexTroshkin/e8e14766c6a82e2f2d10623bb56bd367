using Newtonsoft.Json;

namespace e8e14766c6a82e2f2d10623bb56bd367.Tron.Messages
{
    /// <summary>
    /// Запрос на получение аккаунта
    /// </summary>
    public class GetAccountRequest : ITronRequest
    {
        /// <summary>
        /// Адрес кошелька (hex или base58)
        /// </summary>
        [JsonProperty("address")]
        public string? Address { get; set; }
         
        /// <summary>
        /// Указывает, находится ли переданный адрес в формате base58
        /// </summary>
        [JsonProperty("visible")]
        public bool IsBase58Address { get; set; }
    }
}