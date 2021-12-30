using Newtonsoft.Json;

using System.Collections.Generic;

namespace e8e14766c6a82e2f2d10623bb56bd367.Tron.Messages
{
    /// <summary>
    /// Сводная информация по транзакции
    /// </summary>
    public class TronTransactionSummary
    {
        //private readonly UnixDateTimeConverter _unixDateTimeConverter = new UnixDateTimeConverter();
        
        /// <summary>
        /// Контракты которые были или будут вызваны в процессе исполнения транзакции
        /// </summary>
        [JsonProperty("contract")]
        public IEnumerable<TronContractItem>? Contracts { get; set; }
        
        /// <summary>
        /// Байты блока от вершины которого будет создаваться транзакция
        /// </summary>
        [JsonProperty("ref_block_bytes")]
        public string? RefBlockBytes { get; set; }
        
        /// <summary>
        /// Хэш блока от вершины которого будет создаваться транзакция
        /// </summary>
        [JsonProperty("ref_block_hash")]
        public string? RefBlockHash { get; set; }

        /// <summary>
        /// Когда транзакция истечет (не будет доступна для отправки в блокчейн)
        /// </summary>
        //[JsonIgnore] 
        //public DateTime ExpiresAt => _unixDateTimeConverter.FromUnixTimestampMilliseconds(Expiration);
        
        /// <summary>
        /// Когда транзакция истечет (не будет доступна для отправки в блокчейн) (timestamp)
        /// </summary>
        [JsonProperty("expiration")]
        public long Expiration { get; set; }

        /// <summary>
        /// Когда транзакция была создана
        /// </summary>
        //[JsonIgnore]
        //public DateTime CreatedAt => _unixDateTimeConverter.FromUnixTimestampMilliseconds(Timestamp);
        
        /// <summary>
        /// Когда транзакция была создана (timestamp)
        /// </summary>
        [JsonProperty("timestamp")]
        public long Timestamp { get; set; }
        
        /// <summary>
        /// Лимит сжигания монет (SUN) (только в случае если транзакция была отправлена в блокчейн)
        /// </summary>
        [JsonProperty("fee_limit")]
        public long? FeeLimit { get; set; }
    }
}