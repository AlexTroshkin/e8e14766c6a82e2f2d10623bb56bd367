using Newtonsoft.Json;

namespace e8e14766c6a82e2f2d10623bb56bd367.Tron.Messages
{
    /// <summary>
    /// Квитанция по транзакции (комиссии)
    /// </summary>
    public class TronTransactionReceipt
    {
        /// <summary>
        /// Комиссия (SUN), если не хватило bandwidth
        /// </summary>
        [JsonProperty("net_fee")]
        public long NetFee { get; set; }
        
        /// <summary>
        /// Сколько bandwidth было потрачено (если не потребовалось сжечь trx)
        /// </summary>
        [JsonProperty("net_usage")]
        public long NetUsage { get; set; }
        
        /// <summary>
        /// Результат (только при выполнении смарта, SUCCESS)
        /// </summary>
        [JsonProperty("result")]
        public string? RawResult { get; set; }
        
        /// <summary>
        /// Сколько всего было потрачено энергии
        /// </summary>
        [JsonProperty("energy_usage_total")]
        public long EnergyUsageTotal { get; set; }
        
        /// <summary>
        /// Комиссия в SUN за энергию
        /// </summary>
        [JsonProperty("energy_fee")]
        public long EnergyFee { get; set; }
    }
}