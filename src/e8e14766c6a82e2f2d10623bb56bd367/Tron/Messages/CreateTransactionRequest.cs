using Newtonsoft.Json;

namespace e8e14766c6a82e2f2d10623bb56bd367.Tron.Messages
{
    /// <summary>
    /// Создание (неподписанной) транзакции для отправки TRX
    /// </summary>
    public class CreateTransactionRequest : ITronRequest
    {
        /// <summary>
        /// Адрес отправителя
        /// </summary>
        [JsonProperty("owner_address")]
        public string? FromAddress { get; set; }
        
        /// <summary>
        /// Адрес получателя
        /// </summary>
        [JsonProperty("to_address")]
        public string? ToAddress { get; set; }
        
        /// <summary>
        /// Количество монет (SUN)
        /// </summary>
        [JsonProperty("amount")]
        public long Amount { get; set; }
        
        /// <summary>
        /// Указывает, находится ли переданные адреса в формате base58
        /// </summary>
        [JsonProperty("visible")]
        public bool IsBase58Addresses { get; set; }
    }
}