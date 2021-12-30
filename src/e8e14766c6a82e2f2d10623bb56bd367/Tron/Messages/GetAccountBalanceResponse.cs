using Newtonsoft.Json;

namespace e8e14766c6a82e2f2d10623bb56bd367.Tron.Messages
{
    /// <summary>
    /// Ответ на получение баланса
    /// </summary>
    public class GetAccountBalanceResponse : TronResponseBase
    {
        /// <summary>
        /// Баланс в SUN
        /// </summary>
        [JsonProperty("balance")]
        public long Balance { get; set; }
        
        /// <summary>
        /// Идентификатор блока
        /// </summary>
        [JsonProperty("block_identifier")]
        public TronBlockIdentifier? BlockIdentifier { get; set; }
    }
}