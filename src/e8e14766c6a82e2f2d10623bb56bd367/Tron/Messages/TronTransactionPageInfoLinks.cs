using Newtonsoft.Json;

namespace e8e14766c6a82e2f2d10623bb56bd367.Tron.Messages
{
    /// <summary>
    /// Ссылки со страницы транзакций аккаунта
    /// </summary>
    public class TronTransactionPageInfoLinks
    {
        /// <summary>
        /// URL для запроса следующей страницы
        /// </summary>
        [JsonProperty("next")]
        public string? NextPageUrl { get; set; }
    }
}