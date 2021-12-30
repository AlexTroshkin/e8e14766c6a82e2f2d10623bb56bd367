using Newtonsoft.Json;

namespace e8e14766c6a82e2f2d10623bb56bd367.Tron.Messages
{
    /// <summary>
    /// Статус Tron транзакции
    /// </summary>
    public class TronTransactionStatusItem : TronTransactionContractStatusItem
    {
        [JsonIgnore]
        public bool IsCodeSuccess => Code == "SUCCESS";
        
        /// <summary>
        /// Статус код транзакции
        /// </summary>
        [JsonProperty("code")]
        public string? Code { get; set; }

        /// <summary>
        /// Комиссия
        /// </summary>
        [JsonProperty("fee")]
        public long Fee { get; set; }
    }
}