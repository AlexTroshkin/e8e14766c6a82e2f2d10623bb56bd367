using Newtonsoft.Json;

using System.Collections.Generic;

namespace e8e14766c6a82e2f2d10623bb56bd367.Tron.Messages
{
    /// <summary>
    /// TRON транзакция с запроса /gettransactioninfobyblocknum
    /// </summary>
    public class TronTransactionExtendedItem
    {
        //private UnixDateTimeConverter _unixDateTimeConverter = new UnixDateTimeConverter();
        
        /// <summary>
        /// ID транзакции
        /// </summary>
        [JsonProperty("id")]
        public string? TxId { get; set; }
        
        /// <summary>
        /// Номер блока
        /// </summary>
        [JsonProperty("blockNumber")]
        public long BlockNumber { get; set; }

        /// <summary>
        /// Когда был выработан блок
        /// </summary>
        //[JsonIgnore] 
        //public DateTime BlockMinedAt => _unixDateTimeConverter.FromUnixTimestampMilliseconds(BlockTimestamp);
        
        /// <summary>
        /// Когда был выработан блок (timestamp)
        /// </summary>
        [JsonProperty("blockTimeStamp")]
        public long BlockTimestamp { get; set; }
        
        /// <summary>
        /// Receipt транзакции
        /// </summary>
        [JsonProperty("receipt")]
        public TronTransactionReceipt? Receipt { get; set; }
        
        /// <summary>
        /// HEX-адрес вызываемого смарт-контракта (41...) (присутствует только если это TriggerSmartContract)
        /// </summary>
        [JsonProperty("contract_address")]
        public string? ContractAddress { get; set; }

        /// <summary>
        /// Внутренние транзакции
        /// </summary>
        [JsonProperty("internal_transactions")]
        public IEnumerable<TronInternalTransactionItem>? InternalTransactions { get; set; } = new List<TronInternalTransactionItem>();

        /// <summary>
        /// Event logs
        /// </summary>
        [JsonProperty("log")]
        public IEnumerable<TronEventLogItem>? EventLogs { get; set; } = new List<TronEventLogItem>();
        
        /// <summary>
        /// Комиссия за транзакцию в SUN
        /// </summary>
        [JsonProperty("fee")]
        public long Fee { get; set; }
        
        /// <summary>
        /// Packing fee в SUN (?)
        /// </summary>
        [JsonProperty("packingFee")]
        public long PackingFee { get; set; }
    }
}