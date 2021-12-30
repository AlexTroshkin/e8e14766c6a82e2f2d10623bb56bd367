using System.Collections.Generic;
using Newtonsoft.Json;

namespace e8e14766c6a82e2f2d10623bb56bd367.Tron.Messages
{
    /// <summary>
    /// Транзакция TRON из GetBlockByNumberResponse
    /// </summary>
    public class TronGetBlockByNumberResponseTransaction : TronTransaction
    {
        /// <summary>
        /// Статус транзакции (один элемент)
        /// </summary>
        [JsonProperty("ret")]
        public IEnumerable<TronTransactionContractStatusItem>? Statuses { get; set; }
        
        /// <summary>
        /// Подписи
        /// </summary>
        [JsonProperty("signature")]
        public IEnumerable<string>? Signature { get; set; }
    }
}