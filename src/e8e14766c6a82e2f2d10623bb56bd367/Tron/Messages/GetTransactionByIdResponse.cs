using System.Collections.Generic;
using Newtonsoft.Json;

namespace e8e14766c6a82e2f2d10623bb56bd367.Tron.Messages
{
    /// <summary>
    /// Ответ на запрос получение информации о транзакции по ID
    /// </summary>
    public class GetTransactionByIdResponse : TronTransaction, ITronResponse
    {
        /// <summary>
        /// Статус транзакции (один элемент)
        /// </summary>
        [JsonProperty("ret")]
        public IEnumerable<TronTransactionStatusItem>? Statuses { get; set; }
        
        /// <summary>
        /// Подписи транзакции
        /// </summary>
        [JsonProperty("signature")]
        public IEnumerable<string>? Signatures { get; set; }

        /// <summary>
        /// Ошибка от API Tron
        /// </summary>
        [JsonProperty("Error")]
        public string? Error { get; set; }
    }
}