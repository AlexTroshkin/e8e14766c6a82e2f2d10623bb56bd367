using System.Collections.Generic;
using Newtonsoft.Json;

namespace e8e14766c6a82e2f2d10623bb56bd367.Tron.Messages
{
    /// <summary>
    /// Ответ на получение транзакций по адресу (аккаунту)
    /// </summary>
    public class GetAccountTransactionsResponse : TronResponseBase
    {
        /// <summary>
        /// Получили ли мы транзакции
        /// </summary>
        [JsonProperty("success")]
        public bool IsSuccess { get; set; }
        
        /// <summary>
        /// Информация о полученной странице (пагинация)
        /// </summary>
        [JsonProperty("meta")]
        public TronTransactionsPageInfo? PageInfo { get; set; }
        
        /// <summary>
        /// Транзакции
        /// </summary>
        [JsonProperty("data")]
        public IEnumerable<TronTransactionItem>? Transactions { get; set; }
    }
}