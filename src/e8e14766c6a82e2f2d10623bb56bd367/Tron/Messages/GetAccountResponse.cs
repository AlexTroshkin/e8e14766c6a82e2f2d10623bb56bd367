using Newtonsoft.Json;

using System.Collections.Generic;

namespace e8e14766c6a82e2f2d10623bb56bd367.Tron.Messages
{
    /// <summary>
    /// Ответ на запрос на получения аккаунта
    /// </summary>
    public class GetAccountResponse : TronResponseBase
    {
        //private readonly UnixDateTimeConverter _unixDateTimeConverter = new UnixDateTimeConverter();
        
        /// <summary>
        /// Адрес
        /// </summary>
        [JsonProperty("address")]
        public string? Address { get; set; }
        
        /// <summary>
        /// Баланс (в SUN)
        /// </summary>
        [JsonProperty("balance")]
        public long Balance { get; set; }
        
        /// <summary>
        /// Когда был создан аккаунт
        /// </summary>
        //[JsonIgnore]
        //public DateTime CreatedAt => _unixDateTimeConverter.FromUnixTimestampMilliseconds(CreateTime); 
        
        /// <summary>
        /// Когда был создан аккаунт (timestamp)
        /// </summary>
        [JsonProperty("create_time")]
        public long CreateTime { get; set; }
        
        /// <summary>
        /// Когда была последняя операция на аккаунте
        /// </summary>
        //[JsonIgnore]
        //public DateTime LatestOperationAt => _unixDateTimeConverter.FromUnixTimestampMilliseconds(LatestOperationTime);
        
        /// <summary>
        /// Когда была последняя операция на аккаунте (timestamp)
        /// </summary>
        [JsonProperty("latest_opration_time")]
        public long LatestOperationTime { get; set; }
        
        /// <summary>
        /// Потраченный bandwidth
        /// </summary>
        [JsonProperty("free_net_usage")]
        public long FreeNetUsage { get; set; }
        
        /// <summary>
        /// Последнее получение bandwidth
        /// </summary>
        //[JsonIgnore]
        //public DateTime LatestConsumeFreeTimeAt => _unixDateTimeConverter.FromUnixTimestampMilliseconds(LatestConsumeFreeTime);
        
        /// <summary>
        /// Последнее получение bandwidth (timestamp)
        /// </summary>
        [JsonProperty("latest_consume_free_time")]
        public long LatestConsumeFreeTime { get; set; }
        
        /// <summary>
        /// Ресурсы аккаунта
        /// </summary>
        [JsonProperty("account_resource")]
        public TronAccountResource? AccountResource { get; set; }
        
        /// <summary>
        /// Права владельца
        /// </summary>
        [JsonProperty("owner_permission")]
        public TronOwnerPermission? OwnerPermission { get; set; }
        
        /// <summary>
        /// Активные права
        /// </summary>
        [JsonProperty("active_permission")]
        public IEnumerable<TronActivePermissionItem>? ActivePermission { get; set; }
    }
}