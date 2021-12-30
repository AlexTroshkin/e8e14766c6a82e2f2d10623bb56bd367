using Newtonsoft.Json;

namespace e8e14766c6a82e2f2d10623bb56bd367.Tron.Messages
{
    /// <summary>
    /// Подробная информация о заголовке блока
    /// </summary>
    public class TronBlockHeaderInfo
    {
        //private readonly UnixDateTimeConverter _unixDateTimeConverter = new UnixDateTimeConverter();
        
        /// <summary>
        /// Номер блока
        /// </summary>
        [JsonProperty("number")]
        public long Number { get; set; }
        
        /// <summary>
        /// Root транзакция
        /// </summary>
        [JsonProperty("txTrieRoot")]
        public string? TxTrieRoot { get; set; }
        
        /// <summary>
        /// Адрес свидетеля (майнера?) (?)
        /// </summary>
        [JsonProperty("witness_address")]
        public string? WitnessAddress { get; set; }
        
        /// <summary>
        /// Хэш родительского блока
        /// </summary>
        [JsonProperty("parentHash")]
        public string? ParentHash { get; set; }
        
        /// <summary>
        /// Версия
        /// </summary>
        [JsonProperty("version")]
        public long Version { get; set; }

        /// <summary>
        /// Когда блок был выработан
        /// </summary>
        //[JsonIgnore]
        //public DateTime MinedAt => _unixDateTimeConverter.FromUnixTimestampMilliseconds(Timestamp);
            
        /// <summary>
        /// Когда блок был выработан (timestamp)
        /// </summary>
        [JsonProperty("timestamp")]
        public long Timestamp { get; set; }
    }
}