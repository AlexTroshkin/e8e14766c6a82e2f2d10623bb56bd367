using System.Collections.Generic;
using Newtonsoft.Json;

namespace e8e14766c6a82e2f2d10623bb56bd367.Tron.Messages
{
    /// <summary>
    /// Права владельца
    /// </summary>
    public class TronOwnerPermission
    {
        /// <summary>
        /// Название права (owner_permission)
        /// </summary>
        [JsonProperty("permission_name")]
        public string? PermissionName { get; set; }
        
        /// <summary>
        /// Порог
        /// </summary>
        [JsonProperty("threshold")]
        public long Threshold { get; set; }
        
        /// <summary>
        /// Ключи доступа
        /// </summary>
        [JsonProperty("keys")]
        public IEnumerable<TronPermissionKeyItem>? Keys { get; set; }
    }
}