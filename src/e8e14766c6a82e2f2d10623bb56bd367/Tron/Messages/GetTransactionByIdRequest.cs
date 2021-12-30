using Newtonsoft.Json;

namespace e8e14766c6a82e2f2d10623bb56bd367.Tron.Messages
{
    /// <summary>
    /// Запрос на получение информации о транзакции по ID
    /// </summary>
    public class GetTransactionByIdRequest : ITronRequest
    {
        /// <summary>
        /// ID запрашиваемой транзакции
        /// </summary>
        [JsonProperty("value")]
        public string? TransactionId { get; set; }
    }
}