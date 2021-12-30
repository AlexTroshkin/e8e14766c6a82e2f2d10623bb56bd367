using System.Collections.Generic;
using Newtonsoft.Json;

namespace e8e14766c6a82e2f2d10623bb56bd367.Tron.Messages
{
    /// <summary>
    /// Отправка подписанной транзакции в сеть
    /// </summary>
    public class BroadcastTransactionRequest : ITronRequest
    {
        /// <summary>
        /// ID транзакции
        /// </summary>
        [JsonProperty("txID")]
        public string? TxId { get; set; }
        
        /// <summary>
        /// Переданные адреса находятся в формате base58 
        /// </summary>
        [JsonProperty("visible")]
        public bool IsBase58Addresses { get; set; }
        
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
        
        /// <summary>
        /// Сигнатуры транзакции
        /// </summary>
        [JsonProperty("signature")]
        public IEnumerable<string>? Signature { get; set; }
    }
}