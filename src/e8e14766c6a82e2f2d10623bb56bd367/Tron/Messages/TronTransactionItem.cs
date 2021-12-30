using Newtonsoft.Json;

using System.Collections.Generic;

namespace e8e14766c6a82e2f2d10623bb56bd367.Tron.Messages
{
    /// <summary>
    /// Транзакция TRON
    /// </summary>
    public class TronTransactionItem
    {
        //private readonly UnixDateTimeConverter _unixDateTimeConverter = new UnixDateTimeConverter();
        
        /// <summary>
        /// ID транзакция
        /// </summary>
        [JsonProperty("txID")]
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
        [JsonProperty("block_timestamp")]
        public long BlockTimestamp { get; set; }
        
        /// <summary>
        /// Сколько было потрачено TRX (в SUN) для получения энергии (указывается только когда энергии не хватило)
        /// </summary>
        [JsonProperty("energy_fee")]
        public long EnergyFee { get; set; }
        
        /// <summary>
        /// Сколько было потрачено энергии (только когда энергии хватило)
        /// </summary>
        [JsonProperty("energy_usage")]
        public long EnergyUsage { get; set; } 
        
        /// <summary>
        /// Сколько всего потрачено энергии
        /// </summary>
        [JsonProperty("energy_usage_total")]
        public long EnergyUsageTotal { get; set; }
        
        /// <summary>
        /// Внутренние транзакции
        /// </summary>
        [JsonProperty("internal_transactions")]
        public IEnumerable<object>? InternalTransactions { get; set; }
        
        /// <summary>
        /// Сколько было сожжено TRX (в SUN) для транзакции (указывается только когда не хватило bandwidth)
        /// </summary>
        [JsonProperty("net_fee")]
        public long NetFee { get; set; }
        
        /// <summary>
        /// Сколько было потрачено Bandwidth для транзакции (указывается только когда хватило bandwidth
        /// </summary>
        [JsonProperty("net_usage")]
        public long NetUsage { get; set; }
        
        /// <summary>
        /// Сводка по транзакции
        /// </summary>
        [JsonProperty("raw_data")]
        public TronTransactionSummary? Summary { get; set; }
        
        /// <summary>
        /// Сводка по транзакции в HEX
        /// </summary>
        [JsonProperty("raw_data_hex")]
        public string? SummaryHex { get; set; }
        
        /// <summary>
        /// Статус транзакции (один элемент)
        /// </summary>
        [JsonProperty("ret")]
        public IEnumerable<TronTransactionStatusItem>? Statuses { get; set; }
        
        /// <summary>
        /// Подписи
        /// </summary>
        [JsonProperty("signature")]
        public IEnumerable<string>? Signature { get; set; }
    }
}