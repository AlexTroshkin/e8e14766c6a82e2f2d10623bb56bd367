using Newtonsoft.Json;

namespace e8e14766c6a82e2f2d10623bb56bd367.Tron.Messages
{
    /// <summary>
    /// Запрос на получение баланса по блоку
    /// </summary>
    public class GetAccountBalanceRequest : ITronRequest
    {
        /// <summary>
        /// Идентификатор аккаунта
        /// </summary>
        [JsonProperty("account_identifier")]
        public TronAccountIdentifier? AccountIdentifier { get; set; }
        
        /// <summary>
        /// Идентификатор блока
        /// </summary>
        [JsonProperty("block_identifier")]
        public TronBlockIdentifier? BlockIdentifier { get; set; }

        /// <summary>
        /// Являются ли переданные адреса адресами в формате Base58
        /// </summary>
        [JsonProperty("visible")]
        public bool IsBase58Addresses { get; set; } = true;
    }
}