using System.Collections.Generic;
using Newtonsoft.Json;

namespace e8e14766c6a82e2f2d10623bb56bd367.Tron.Messages
{
    /// <summary>
    /// Активное право
    /// </summary>
    public class TronActivePermissionItem
    {
        /// <summary>
        /// Тип
        /// </summary>
        [JsonProperty("type")]
        public string? Type { get; set; }
        
        /// <summary>
        /// Идентификатор
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }
        
        /// <summary>
        /// Название
        /// </summary>
        [JsonProperty("permission_name")]
        public string? Name { get; set; }
        
        /// <summary>
        /// Порог
        /// </summary>
        [JsonProperty("threshold")]
        public long Threshold { get; set; }
        
        /// <summary>
        /// Доступные операции (в формате Hex string)
        /// </summary>
        [JsonProperty("operations")]
        public string? Operations { get; set; }
        
        /// <summary>
        /// Ключи доступа
        /// </summary>
        [JsonProperty("keys")]
        public IEnumerable<TronPermissionKeyItem>? Keys { get; set; }
    }
}