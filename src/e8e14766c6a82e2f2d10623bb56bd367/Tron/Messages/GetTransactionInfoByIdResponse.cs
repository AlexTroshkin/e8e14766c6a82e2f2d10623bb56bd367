using Newtonsoft.Json;

using System.Collections.Generic;

namespace e8e14766c6a82e2f2d10623bb56bd367.Tron.Messages
{
    /// <summary>
    /// Ответ на запрос получения транзакции по ID
    /// </summary>
    public class GetTransactionInfoByIdResponse : TronResponseBase
    {
        //private readonly UnixDateTimeConverter _unixDateTimeConverter = new UnixDateTimeConverter();
        
        /// <summary>
        /// ID транзакции
        /// </summary>
        [JsonProperty("id")]
        public string? Id { get; set; }
        
        /// <summary>
        /// Комиссия для отправки транзакции (SUN), присутствует в случае нехватки bandwidth для исполнения tx
        /// </summary>
        [JsonProperty("fee")]
        public long Fee { get; set; }
        
        /// <summary>
        /// Блок, в котором находится транзакция
        /// </summary>
        [JsonProperty("blockNumber")]
        public long BlockNumber { get; set; }
        
        /// <summary>
        /// Когда блок в котором находится транзакция был выработан
        /// </summary>
        //[JsonIgnore]
        //public DateTime BlockMinedAt => _unixDateTimeConverter.FromUnixTimestampMilliseconds(BlockTimestamp);
        
        /// <summary>
        /// Когда блок в котором находится транзакция был выработан (timestamp)
        /// </summary>
        [JsonProperty("blockTimeStamp")]
        public long BlockTimestamp { get; set; }
        
        /// <summary>
        /// Результаты выполнения смарт-контрактов
        /// </summary>
        [JsonProperty("contractResult")]
        public IEnumerable<string>? ContractsResult { get; set; }
        
        /// <summary>
        /// Квитанция транзакции (данные о использованной комиссии)
        /// </summary>
        [JsonProperty("receipt")]
        public TronTransactionReceipt? Receipt { get; set; }
    }
}