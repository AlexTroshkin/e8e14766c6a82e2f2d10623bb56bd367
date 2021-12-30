using Newtonsoft.Json;

namespace e8e14766c6a82e2f2d10623bb56bd367.Tron.Messages
{
    /// <summary>
    /// Запрос на получение транзакции по Id
    /// </summary>
    public class GetTransactionInfoByIdRequest : ITronRequest
    {
        /// <summary>
        /// ID транзакции
        /// </summary>
        [JsonProperty("value")]
        public string? TxId { get; set; }
    }
}