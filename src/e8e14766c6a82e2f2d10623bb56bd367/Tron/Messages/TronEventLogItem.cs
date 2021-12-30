using System.Collections.Generic;
using Newtonsoft.Json;

namespace e8e14766c6a82e2f2d10623bb56bd367.Tron.Messages
{
    /// <summary>
    /// Event Log
    /// </summary>
    public class TronEventLogItem
    {
        /// <summary>
        /// Адрес контракта, который сгенерировал event
        /// </summary>
        [JsonProperty("address")]
        public string? Address { get; set; }
        
        /// <summary>
        /// Неиндексированные данные (к примеру _value в event Transfer)
        /// </summary>
        [JsonProperty("data")]
        public string? Data { get; set; }
        
        /// <summary>
        /// Топики. Первый элемемент - хэш от сигнатуры эвента, остальные - индексированные параметры.
        /// К примеру для event Transfer первый элемент будет: ddf252ad1be2c89b69c2b068fc378daa952ba7f163c4a11628f55a4df523b3ef
        /// И следующие 2 от кого и кому
        /// </summary>
        [JsonProperty("topics")]
        public IEnumerable<string> Topics = new List<string>();
    }
}