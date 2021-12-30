using Newtonsoft.Json;

namespace e8e14766c6a82e2f2d10623bb56bd367.Tron.Messages
{
    /// <summary>
    /// Идентификатор аккаунта
    /// </summary>
    public class TronAccountIdentifier
    {
        public TronAccountIdentifier(string address)
        {
            Address = address;
        }
        
        /// <summary>
        /// Адрес
        /// </summary>
        [JsonProperty("address")]
        public string? Address { get; set; }
    }
}