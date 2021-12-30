using System.Collections.Generic;
using Newtonsoft.Json;

namespace e8e14766c6a82e2f2d10623bb56bd367.Tron.Messages
{
    /// <summary>
    /// Ответ на запрос получения блока по номеру
    /// </summary>
    public class GetBlockByNumberResponse : TronBlockBase
    {
        /// <summary>
        /// Транзакции
        /// </summary>
        [JsonProperty("transactions")]
        public IEnumerable<TronGetBlockByNumberResponseTransaction> Transactions { get; set; } = new List<TronGetBlockByNumberResponseTransaction>();
    }
}