using Newtonsoft.Json;

namespace e8e14766c6a82e2f2d10623bb56bd367.Tron.Messages
{
    /// <summary>
    ///  Данные о транзакции
    /// </summary>
    public class TronTransaction
    {
        /// <summary>
        /// ID транзакции (hash)
        /// </summary>
        [JsonProperty("txID")]
        public string? TxId { get; set; }
        
        /// <summary>
        /// Сводка по транзакции
        /// </summary>
        [JsonProperty("raw_data")]
        public TronTransactionSummary? Summary { get; set; }
        
        /// <summary>
        /// Сводка по транзакции (Hex)
        /// </summary>
        [JsonProperty("raw_data_hex")]
        public string? SummaryHex { get; set; }
    }
}